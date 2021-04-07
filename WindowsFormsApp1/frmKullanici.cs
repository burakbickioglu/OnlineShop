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
        BakiyeManager bakiyeManager = new BakiyeManager(new EfBakiyeDal());
        List<Urun> _uruns = new List<Urun>();
        UrunManager urunManager = new UrunManager(new EfUrunDal());
        AlisEmir alisEmir = new AlisEmir();
        AlisEmirManager alisManager = new AlisEmirManager(new EfAlisEmirDal());
        List<UserStockDto> _stok = new List<UserStockDto>();
        StokManager stokManager = new StokManager(new EfStokDal());


        private void frmKullanici_Load(object sender, EventArgs e)
        {
            _bakiye.KullaniciId = _kullanici.KullaniciId;
            _bakiye = bakiyeManager.Get(_bakiye);
            lblAdSoyad.Text = _kullanici.Ad + " " + _kullanici.Soyad;
            
            lblBakiye.Text = Math.Round(Convert.ToDecimal(_bakiye.MevcutBakiye),2) + " TL";
            lblTc.Text = _kullanici.TcNo;
            lblTel.Text = _kullanici.TelNo;


            
            _uruns = urunManager.GetAll();
            foreach (var urun in _uruns)
            {
                cmbAlinacakUrun.Items.Add(urun.UrunAd);
            }


            _stok = stokManager.GetUserStockDetail(_kullanici);
            
            dataGridView1.DataSource = _stok;



        }

        private void btnAlis_Click(object sender, EventArgs e)
        {
            alisEmir.AliciId = _kullanici.KullaniciId;
            alisEmir.UrunId = urunManager.Get(new Urun {UrunAd = cmbAlinacakUrun.Text}).UrunId;
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

        }
    }
}
