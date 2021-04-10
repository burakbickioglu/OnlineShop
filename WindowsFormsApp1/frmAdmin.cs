using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace WindowsFormsApp1
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        List<Kullanici> _kullanicilar = new List<Kullanici>();
        Kullanici _kullanici = new Kullanici();

        List<Bakiye> _bakiyeler = new List<Bakiye>();
        Bakiye _bakiye = new Bakiye();

        List<Stok> _stoklar = new List<Stok>();
        Stok _stok = new Stok();


        BakiyeManager bakiyeManager = new BakiyeManager(new EfBakiyeDal());
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        private StokManager stokManager = new StokManager(new EfStokDal());

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            grpBakiyeOnay.Visible = false;
            grpStokOnay.Visible = false;
            KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
            BakiyeManager bakiyeManager = new BakiyeManager(new EfBakiyeDal());
            
            _kullanicilar = kullaniciManager.GetAll();


        }

        public void kullaniciListele()
        {
            DataGridScreen.DataSource = _kullanicilar;
            
        }

        public void bakiyeGoruntule()
        {
            _bakiyeler = bakiyeManager.GetAll().Where(p => p.BakiyeOnay == false).ToList();
            DataGridScreen.DataSource = _bakiyeler;
        }

        public void stokGoruntule()
        {
            _stoklar = stokManager.GetAll().Where(p => p.UrunOnay == false).ToList();
            DataGridScreen.DataSource = _stoklar;
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            kullaniciListele();
        }


        private void btnStok_Click(object sender, EventArgs e)
        {
            grpBakiyeOnay.Visible = false;
            grpStokOnay.Visible = true;
            stokGoruntule();

        }

        private void btnBakiye_Click_1(object sender, EventArgs e)
        {
            grpStokOnay.Visible = false;
            grpBakiyeOnay.Visible = true;
            bakiyeGoruntule();

        }

        
        

        private void DataGridScreen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (DataGridScreen.DataSource == _bakiyeler)
            {
                int secilen = DataGridScreen.SelectedCells[0].RowIndex;
                _bakiye.KullaniciId = Convert.ToInt16(DataGridScreen.Rows[secilen].Cells[0].Value);
                _bakiye.MevcutBakiye = Convert.ToDecimal(DataGridScreen.Rows[secilen].Cells[1].Value);
                _bakiye.EklenecekBakiye = Convert.ToDecimal(DataGridScreen.Rows[secilen].Cells[2].Value);
                _bakiye.BakiyeOnay = Convert.ToBoolean(DataGridScreen.Rows[secilen].Cells[3].Value);
                lblEklenecekBakiye.Text = _bakiye.EklenecekBakiye.ToString();
                _kullanici.KullaniciId = Convert.ToInt16(DataGridScreen.Rows[secilen].Cells[0].Value);
                _kullanici = kullaniciManager.GetAll().FirstOrDefault(p=>p.KullaniciId==_kullanici.KullaniciId);
                lblKullaniciAdi.Text = _kullanici.Ad + " " + _kullanici.Soyad;
            }

            else if (DataGridScreen.DataSource == _stoklar)
            {
                int secilen = DataGridScreen.SelectedCells[0].RowIndex;
                _stok.KullaniciId = Convert.ToInt16(DataGridScreen.Rows[secilen].Cells[1].Value);
                _stok.UrunId = Convert.ToInt16(DataGridScreen.Rows[secilen].Cells[2].Value);


                lblEklenecekStok.Text = _stok.UrunMiktar.ToString();

                _kullanici.KullaniciId = Convert.ToInt16(DataGridScreen.Rows[secilen].Cells[1].Value);
                _kullanici = kullaniciManager.GetAll().FirstOrDefault(p => p.KullaniciId == _kullanici.KullaniciId);
                lblKullaniciAdi2.Text = _kullanici.Ad + " " + _kullanici.Soyad;

                _stok = stokManager.GetAll()
                    .FirstOrDefault(p => p.KullaniciId == _stok.KullaniciId && p.UrunId == _stok.UrunId);
            }
        }

        private void btnBakiyeOnayla_Click(object sender, EventArgs e)
        {
            _bakiye.MevcutBakiye += _bakiye.EklenecekBakiye;
            _bakiye.EklenecekBakiye = 0;
            _bakiye.BakiyeOnay = true;
            var result = bakiyeManager.Update(_bakiye);
            if (result)
            {
                MessageBox.Show(_kullanici.Ad + " " + _kullanici.Soyad + " kullanıcısının bakiye ekleme işlemi onaylandı");
            }
            else
            {
                MessageBox.Show("İşlem onaylanamadı");
            }
            bakiyeGoruntule();
            
        }

        private void btnStokOnayla_Click(object sender, EventArgs e)
        {
            _stok.UrunOnay = true;
            var result = stokManager.Update(_stok);
            if (result)
            {
                MessageBox.Show(_kullanici.Ad + " " + _kullanici.Soyad + " kullanıcısının stok ekleme işlemi onaylandı");
            }
            else
            {
                MessageBox.Show("İşlem onaylanamadı");
            }
            stokGoruntule();
            
        }
    }
}
