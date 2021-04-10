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
        List<Bakiye> _bakiyeler = new List<Bakiye>();
        private void frmAdmin_Load(object sender, EventArgs e)
        {
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

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            kullaniciListele();
        }


        private void btnStok_Click(object sender, EventArgs e)
        {

        }

        private void btnBakiye_Click_1(object sender, EventArgs e)
        {
            bakiyeGoruntule();

        }

        
        Bakiye _bakiye = new Bakiye();
        BakiyeManager bakiyeManager = new BakiyeManager(new EfBakiyeDal());
        Kullanici _kullanici = new Kullanici();
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());

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
    }
}
