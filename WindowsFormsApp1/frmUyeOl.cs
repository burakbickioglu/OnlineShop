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
            KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
            kullanici.Ad = txtAd.Text;
            kullanici.Soyad = txtSoyad.Text;
            kullanici.TelNo = txtTel.Text;
            kullanici.KullaniciAd = txtKullaniciAd.Text;
            kullanici.KullaniciSifre = txtSifre.Text;
            var result = kullaniciManager.Add(kullanici);
            if (result)
            {
                MessageBox.Show("Kayıt Tamamlandı");
            }
            else
            {
                MessageBox.Show("Kullanıcı eklenemedi.");
            }
            
        }
    }
}
