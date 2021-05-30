using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApp1
{
    public partial class frmRapor : Form
    {
        // Kullanılacak nesne ve listeler oluşturulur
        Kullanici _kullanici;
        List<AlimSatim> alimSatims;
        List<BuyingSellingHistory> BuySellHistory = new List<BuyingSellingHistory>();

        // Oluşturulan nesneler ile ilgili işlemlerin yapılabilmesi için manager nesneleri oluşturulur
        AlimSatimManager alimSatimManager = new AlimSatimManager(new EfAlimSatimDal());
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        UrunManager urunManager = new UrunManager(new EfUrunDal());


        public frmRapor(Kullanici kullanici)
        {
            _kullanici = kullanici;
            InitializeComponent();
        }

        

        private void btnRapor_Click(object sender, EventArgs e)
        {
            // Başlangıç tarihi bitiş tarihinden büyük ise kullanıcıya hata mesajı gösterilir
            if (datetimeBaslangic.Value.Date > datetimeBitis.Value.Date)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz !");
                this.Close();
            }

            else
            {
                // Kullanıcıya ait ilgili tarih aralığındaki alım-satımlar veritabanından getirilir
                alimSatims = alimSatimManager.GetAll()
                .Where(p => p.AliciId == _kullanici.KullaniciId || p.SaticiId == _kullanici.KullaniciId).Where(p => p.Tarih.Date >= datetimeBaslangic.Value.Date && p.Tarih <= datetimeBitis.Value.Date).ToList();

                // Eğer getirilen kayıt null değilse yani mevcutsa, if koşuluna girilir
                if (alimSatims != null)
                {
                    foreach (var alimSatim in alimSatims)
                    {

                        // Her bir kayıt gezilerek bir DTO olan BuyingSellingHistory dto' suna atılır, daha sonra BuySellHistory listesine eklenir
                        BuySellHistory.Add(
                            new BuyingSellingHistory
                            {
                                AliciAdi = kullaniciManager.getById(new Kullanici { KullaniciId = alimSatim.AliciId })
                                    .KullaniciAd,
                                SaticiAdi = kullaniciManager.getById(new Kullanici { KullaniciId = alimSatim.SaticiId })
                                    .KullaniciAd,
                                UrunAdi = urunManager.getById(new Urun { UrunId = alimSatim.UrunId }).UrunAd,
                                Miktar = alimSatim.Miktar,
                                Tarih = alimSatim.Tarih,
                                ToplamFiyat = alimSatim.ToplamFiyat
                            }
                        );

                    }
                    // datagridview arayüzde görüntülenmez, pdf kaynağı olması amacıyla tanımlanmış ve gizlenmiştir. Aşağıda data kaynağı olarak elimizdeki listeyi veriyoruz
                    dataGridView1.DataSource = BuySellHistory;

                }

                // eğer alimsatims listesi yani alışveriş geçmişi boş ise, alışveriş geçmişi bulunmamaktadır mesajı gösterilir.
                else
                {
                    MessageBox.Show("Alım satım geçmişi bulunmamaktadır !");
                }

                
                if (dataGridView1.Rows.Count > 0)

                {
                    // Datagridde kayıt var ise,pdf dosya filtresi ve adı belirtilir
                    SaveFileDialog save = new SaveFileDialog();

                    save.Filter = "PDF (*.pdf)|*.pdf";

                    save.FileName = "Rapor.pdf";

                    bool ErrorMessage = false;

                    if (save.ShowDialog() == DialogResult.OK) // eğer dosya kayıt ekranına gelinebilirse if koşuluna girilir
                    {
                        if (File.Exists(save.FileName))
                        {
                            try
                            {
                                // eğer aynı isimde bir dosya var ise, var olan dosyayla değiştirme mesajı gelir
                                File.Delete(save.FileName);
                            }
                            catch (Exception ex)
                            {   // var olan dosya silinemez ise, dosya diske yazılamadı hatası gösterilir
                                ErrorMessage = true;
                                MessageBox.Show("Dosya diske yazılamadı !" + ex.Message);
                            }
                        }
                        if (!ErrorMessage) // eğer aynı isimde dosya yoksa ya da varolan dosya başarıyla silinmişse bu if şartına girilir
                        {
                            try
                            {
                                // bir pdf tablosu oluşturulur, bu tablonun kolon sayısı datagridin kolon sayısıyla eşit olur
                                PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                                // tablonun tasarım özellikleri aşağıda tanımlanmıştır
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;
                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                                // datagridview kolonları tek tek gezilip pdf tablosuna kolon olarak eklenirler
                                foreach (DataGridViewColumn col in dataGridView1.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pTable.AddCell(pCell);
                                }
                                // aynı şekilde datagridview satırları gezilerek, yeni bir döngüyle tek tek hücreler gezilerek tabloya yazılırlar
                                foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                                {
                                    foreach (DataGridViewCell dcell in viewRow.Cells)
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                }
                                // Aşağıda pdf dökümanı oluşturulup, tasarım boyutu vs. verilmiştir. Daha sonra oluşturulan nesneler kapatılmıştır.
                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                                {
                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                    PdfWriter.GetInstance(document, fileStream);
                                    document.Open();
                                    document.Add(pTable);
                                    document.Close();
                                    fileStream.Close();
                                }
                                // Dosya yazılıp oluşturulduktan sonra kullanıcıya işlemin başarılı olduğu bildirilir
                                MessageBox.Show("Rapor başarıyla oluşturuldu !", "Bilgi");
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Rapor dışa aktarılırken hata meydana geldi ! " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Geçmiş alışverişiniz bulunmamaktadır !", "Bilgi");
                }
            }
        }
    }
}
