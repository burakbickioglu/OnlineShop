using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace OnlineShopUI
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            KullaniciManager km = new KullaniciManager(new EfKullaniciDal());



        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            frmUyeOl fr = new frmUyeOl();
            fr.Show();
        }
    }
}
