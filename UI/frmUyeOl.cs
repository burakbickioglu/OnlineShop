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

namespace UI
{
    public partial class frmUyeOl : Form
    {
        public frmUyeOl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            k.Ad = textBox1.Text;
            KullaniciManager km = new KullaniciManager(new EfKullaniciDal());
            var result = km.Add(k);
            
        }

        private void frmUyeOl_Load(object sender, EventArgs e)
        {

        }
    }
}
