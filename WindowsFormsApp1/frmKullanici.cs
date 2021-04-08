using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;

namespace WindowsFormsApp1
{
    public partial class frmKullanici : Form
    {
        private Kullanici _kullanici;
        public frmKullanici(Kullanici kullanici)
        {
            _kullanici = kullanici;
            InitializeComponent();
        }

        Bakiye _bakiye = new Bakiye();
        List<Urun> _uruns = new List<Urun>();
        List<UserStockDto> _stok = new List<UserStockDto>();
        List<Stok> _userStok = new List<Stok>();
        

        BakiyeManager bakiyeManager = new BakiyeManager(new EfBakiyeDal());
        UrunManager urunManager = new UrunManager(new EfUrunDal());
        AlisEmirManager alisManager = new AlisEmirManager(new EfAlisEmirDal());
        StokManager stokManager = new StokManager(new EfStokDal());
        IlanManager ilanManager = new IlanManager(new EfIlanDal());


        private void frmKullanici_Load(object sender, EventArgs e)
        {
            _bakiye.KullaniciId = _kullanici.KullaniciId;
            _bakiye = bakiyeManager.Get(_bakiye);
            lblAdSoyad.Text = _kullanici.Ad + " " + _kullanici.Soyad;

            lblBakiye.Text = Math.Round(Convert.ToDecimal(_bakiye.MevcutBakiye), 2) + " TL";
            lblTc.Text = _kullanici.TcNo;
            lblTel.Text = _kullanici.TelNo;


            datagridList();

            alinacakUrunDoldur();
            satilacakUrunDoldur();

            // datagrid doldurma

            
        }

        void alinacakUrunDoldur()
        {
            //alınacak ürün doldurma

            _uruns = urunManager.GetAll();
            foreach (var urun in _uruns)
            {
                cmbAlinacakUrun.Items.Add(urun.UrunAd);
            }
        }


        void satilacakUrunDoldur()
        {
            // satılabilecek ürünleri listeleme

            foreach (var stok in _stok)
            {
                if (Convert.ToBoolean(stok.UrunOnay))
                {
                    cmbSatilacakUrun.Items.Add(stok.UrunAd);
                }
            }

        }

        private void btnAlis_Click(object sender, EventArgs e)
        {

            AlisEmir alisEmir = new AlisEmir();
            alisEmir.AliciId = _kullanici.KullaniciId;
            alisEmir.UrunId = urunManager.Get(new Urun { UrunAd = cmbAlinacakUrun.Text }).UrunId;
            alisEmir.Miktar = Convert.ToInt16(txtAlinacakMiktar.Text);
            alisEmir.Durum = false;
            var result = alisManager.Add(alisEmir);
            if (result)
            {
                MessageBox.Show("Alış emri verildi!");
            }
            else
            {
                MessageBox.Show("Emir verilemedi");
            }

            satilacakUrunDoldur();

        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            Ilan ilan = new Ilan();
            ilan.UrunId = urunManager.Get(new Urun { UrunAd = cmbSatilacakUrun.Text }).UrunId;
            ilan.Miktar = Convert.ToInt16(txtSatilacakMiktar.Text);
            ilan.BirimFiyat = Convert.ToInt16(txtBirimFiyat.Text);
            ilan.SaticiId = _kullanici.KullaniciId;
            ilan.Durum = false;
            

            Stok temp = stokManager.GetAll()
                .FirstOrDefault(p => p.KullaniciId == _kullanici.KullaniciId && p.UrunId == ilan.UrunId);

            if (temp.UrunMiktar >= ilan.Miktar)
            {
                temp.UrunMiktar -= ilan.Miktar;
                var result2 = stokManager.Update(temp);
                var result = ilanManager.Add(ilan);
                MessageBox.Show("Satış emri verildi!");
            }

            else
            {
                MessageBox.Show("Ürün yetersiz");
            }
            
            datagridList();
            

        }

        public void datagridList()
        {
            _stok = stokManager.GetUserStockDetail(_kullanici);
            dataGridView1.DataSource = _stok;

            _userStok = stokManager.GetAll().Where(p => p.KullaniciId == _kullanici.KullaniciId).ToList();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmStokEkle fr = new frmStokEkle(_kullanici);
            fr.ShowDialog();
            datagridList();
        }


        private void btnDataGridYenile_Click(object sender, EventArgs e)
        {
            datagridList();
            
        }
    }
}
