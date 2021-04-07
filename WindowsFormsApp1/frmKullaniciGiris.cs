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
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        Kullanici kullanici = new Kullanici();
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad = txtKullaniciAd.Text;
            string sifre = txtKullaniciSifre.Text;
            kullanici = kullaniciManager.UserControl(ad, sifre);
            frmKullanici frmKullanici = new frmKullanici(kullanici);
            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            else 
            {
                frmKullanici.ShowDialog();
            }
            



        }
    }
}
