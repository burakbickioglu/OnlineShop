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
            
            
            Kullanici kullanici = new Kullanici();
            Bakiye bakiye = new Bakiye();
            KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
            BakiyeManager bakiyeManager = new BakiyeManager(new EfBakiyeDal());
            
            kullanici.Ad = txtAd.Text;
            kullanici.Soyad = txtSoyad.Text;
            kullanici.TelNo = txtTel.Text;
            kullanici.KullaniciAd = txtKullaniciAd.Text;
            kullanici.KullaniciSifre = txtSifre.Text;
            var result = kullaniciManager.Add(kullanici);
            bakiye.KullaniciId = kullaniciManager.Get(kullanici).KullaniciId;
            bakiye.MevcutBakiye = 0;
            var result2 = bakiyeManager.Add(bakiye);
                

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
