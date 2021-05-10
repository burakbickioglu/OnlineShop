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
            // ilgili textboxlara girilen değer geçici değişkenlere atanır.
            string ad = txtKullaniciAd.Text;
            string sifre = txtKullaniciSifre.Text;

            // kullanıcının bilgileri doğrulanır
            kullanici = kullaniciManager.UserControl(ad, sifre);
            frmKullanici frmKullanici = new frmKullanici(kullanici);

            // veritabanında admin bulunmadığı için geçici bir kontrol yapıyoruz
            if (ad == "admin" && sifre == "1234")
            {
                frmAdmin fr = new frmAdmin();
                fr.ShowDialog();
            }
            // Kullanıcı bilgisi yanlış ise mesaj döndürüyoruz
            else if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            // Kullanıcı bilgileri doğru ise kullanıcı formunu çağırıyoruz
            else
            {
                frmKullanici.ShowDialog();
            }




        }


    }
}
