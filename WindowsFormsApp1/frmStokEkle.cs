using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace WindowsFormsApp1
{
    public partial class frmStokEkle : Form
    {
        List<Urun> _uruns = new List<Urun>();
        Stok _stok = new Stok();
        Kullanici _kullanici;

        StokManager stokManager = new StokManager(new EfStokDal());
        UrunManager urunManager = new UrunManager(new EfUrunDal());
        
        public frmStokEkle(Kullanici kullanici)
        {
            _kullanici = kullanici;
            InitializeComponent();
        }

        private void frmStokEkle_Load(object sender, EventArgs e)
        {

            _uruns = urunManager.GetAll();
            foreach (var urun in _uruns)
            {
                cmbEklenecekUrun.Items.Add(urun.UrunAd);
            }

        }

        private void btnIstekGonder_Click(object sender, EventArgs e)
        {
            // istek gönder butonuna tıklandığında ilgili stok güncellenir ve durumu false olarak güncellenir. Böylelikle admin bu isteği görüntüleyip onaylayabilecektir.
            _stok.KullaniciId = _kullanici.KullaniciId;
            _stok.UrunId = urunManager.Get(new Urun { UrunAd = cmbEklenecekUrun.Text }).UrunId;
            _stok.UrunMiktar = Convert.ToInt16(txtMiktar.Text);
            _stok.UrunOnay = false;
            var kontrol = stokManager.GetAll().SingleOrDefault(p => p.KullaniciId == _stok.KullaniciId && p.UrunId == _stok.UrunId);

            
            Stok temp = stokManager.GetAll().FirstOrDefault(p => p.KullaniciId == _kullanici.KullaniciId && p.UrunId == _stok.UrunId);

            if (temp != null)
            {
                temp.UrunMiktar += _stok.UrunMiktar;
                temp.UrunOnay = false;
                var result = stokManager.Update(temp);
            }
            else
            {
                var result = stokManager.Add(_stok);
            }
            
            MessageBox.Show("Ürün ekleme talebi admin onayına gönderildi");

        }
    }
}
