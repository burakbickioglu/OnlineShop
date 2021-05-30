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
    public partial class frmBakiyeEkle : Form
    {
        private Bakiye _bakiye;
        private List<Doviz> _doviz;

        private BakiyeManager _bakiyeManager;
        private DovizManager _dovizManager = new DovizManager(new EfDovizDal());
        public frmBakiyeEkle(Bakiye bakiye, BakiyeManager bakiyeManager)
        {
            // parametre olarak gelen değişkenlerin referansı yerel değişkenlerin referanslarına aktarılır
            _bakiye = bakiye;
            _bakiyeManager = bakiyeManager;
            InitializeComponent();
        }

        private void frmBakiyeEkle_Load(object sender, EventArgs e)
        {
            dovizDoldur();
        }

        void dovizDoldur()
        {
            // comboboxa döviz türlerinin doldurulması

            _doviz = _dovizManager.GetAll();
            foreach (var doviz in _doviz)
            {
                cmbDoviz.Items.Add(doviz.DovizAd);
            }
        }
        private void btnIstekGonder_Click(object sender, EventArgs e)
        {
            // istek gönder butonuna basıldığı zaman bakiye güncellenir ve false durumuna çekilir. Böylece admin bu isteği görebilir
            decimal eklenecek = Convert.ToDecimal(txtTutar.Text);
            _bakiye.EklenecekBakiye += eklenecek;
            _bakiye.BakiyeOnay = false;
            _bakiye.DovizId = _dovizManager.GetByName(cmbDoviz.Text).DovizId;
            var result = _bakiyeManager.Update(_bakiye);
            if (result)
            {
                MessageBox.Show("Bakiye yükleme talebi admin onayına gönderildi.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bakiye yüklenemedi");
            }
        }
    }
}
