using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace WindowsFormsApp1
{
    public partial class frmUyeOl : Form
    {

        public frmUyeOl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // ilgili nesneler oluşturuluyor
            Kullanici kullanici = new Kullanici();
            Bakiye bakiye = new Bakiye();
            List<Urun> uruns = new List<Urun>();

            // ilgili manager nesneleri oluşturuluyor 
            KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
            BakiyeManager bakiyeManager = new BakiyeManager(new EfBakiyeDal());
            UrunManager urunManager = new UrunManager(new EfUrunDal());
            StokManager stokManager = new StokManager(new EfStokDal());

            // girilen bilgiler kullanıcı nesnesine aktarılıyor
            kullanici.Ad = txtAd.Text;
            kullanici.Soyad = txtSoyad.Text;
            kullanici.TelNo = txtTel.Text;
            kullanici.KullaniciAd = txtKullaniciAd.Text;
            kullanici.KullaniciSifre = txtSifre.Text;
            kullanici.TcNo = txtTcNo.Text;
            kullanici.eMail = txtEmail.Text;
            kullanici.Adres = rchAdres.Text;

            var result = kullaniciManager.Add(kullanici);
            bakiye.KullaniciId = kullaniciManager.Get(kullanici).KullaniciId;
            bakiye.MevcutBakiye = 0;
            bakiye.EklenecekBakiye = 0;
            bakiye.DovizId = 1;
            bakiye.BakiyeOnay = true;
            var result2 = bakiyeManager.Add(bakiye);

            kullanici = kullaniciManager.Get(kullanici);
            uruns = urunManager.GetAll();

            // ürün tablosuna kullanıcının boş stokları ekleniyor
            foreach (var urun in uruns)
            {
                Stok stok = new Stok();
                stok.KullaniciId = kullanici.KullaniciId;
                stok.UrunId = urun.UrunId;
                stok.UrunMiktar = 0;
                stok.UrunOnay = false;
                stokManager.Add(stok);
            }

            
            if (result)
            {
                MessageBox.Show("Kayıt Tamamlandı");
            }
            else
            {
                MessageBox.Show("Kullanıcı eklenemedi.");
            }
            
        }

        private void frmUyeOl_Load(object sender, EventArgs e)
        {

        }
    }
}
