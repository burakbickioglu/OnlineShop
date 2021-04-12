using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Concrete;
using Entities.Concrete;

namespace WindowsFormsApp1
{
    public partial class frmBakiyeEkle : Form
    {
        private Bakiye _bakiye;
        private BakiyeManager _bakiyeManager;
        public frmBakiyeEkle(Bakiye bakiye, BakiyeManager bakiyeManager)
        {
            _bakiye = bakiye;
            _bakiyeManager = bakiyeManager;
            InitializeComponent();
        }

        private void frmBakiyeEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIstekGonder_Click(object sender, EventArgs e)
        {
            decimal eklenecek = Convert.ToDecimal(txtTutar.Text);
            _bakiye.EklenecekBakiye += eklenecek;
            _bakiye.BakiyeOnay = false;
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
