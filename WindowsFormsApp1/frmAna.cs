using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace WindowsFormsApp1
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            // üye ol butonuna tıklandığında ilgili form çağrılır.
            frmUyeOl uyeOl = new frmUyeOl();
            uyeOl.ShowDialog();
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
            // kullanıcı girişi butonuna tıklandığında ilgili form çağrılır.
            frmKullaniciGiris girisYap = new frmKullaniciGiris();
            girisYap.ShowDialog();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            // admin girişi butonuna tıklandığında ilgili form çağrılır.
            frmKullaniciGiris girisYap = new frmKullaniciGiris();
            girisYap.ShowDialog();
        }
    }
}
