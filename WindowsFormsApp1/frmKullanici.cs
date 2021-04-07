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
    public partial class frmKullanici : Form
    {
        private Kullanici _kullanici;
        public frmKullanici(Kullanici kullanici)
        {
            _kullanici = kullanici;
            InitializeComponent();
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            Bakiye _bakiye = new Bakiye();
            BakiyeManager bakiyeManager = new BakiyeManager(new EfBakiyeDal());
            _bakiye = bakiyeManager.GetById(_kullanici.KullaniciId);
            lblAdSoyad.Text = _kullanici.Ad + " " + _kullanici.Soyad;
            lblBakiye.Text = _bakiye.MevcutBakiye.ToString() + " TL";
            lblTc.Text = _kullanici.TcNo;
            lblTel.Text = _kullanici.TelNo;

        }
    }
}
