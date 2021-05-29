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
        Kullanici _kullanici;
        List<AlimSatim> alimSatims;
        List<BuyingSellingHistory> BuySellHistory = new List<BuyingSellingHistory>();


        AlimSatimManager alimSatimManager = new AlimSatimManager(new EfAlimSatimDal());
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
        UrunManager urunManager = new UrunManager(new EfUrunDal());


        public frmRapor(Kullanici kullanici)
        {
            _kullanici = kullanici;
            InitializeComponent();
        }

        private void frmRapor_Load(object sender, EventArgs e)
        {
           

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            if (datetimeBaslangic.Value.Date > datetimeBitis.Value.Date)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz !");
                //MessageBox.Show(datetimeBaslangic.Value.Date + " " + datetimeBitis.Value.Date);
                this.Close();

            }

            else
            {
                alimSatims = alimSatimManager.GetAll()
                .Where(p => p.AliciId == _kullanici.KullaniciId || p.SaticiId == _kullanici.KullaniciId).Where(p => p.Tarih.Date >= datetimeBaslangic.Value.Date && p.Tarih <= datetimeBitis.Value.Date).ToList();

                if (alimSatims != null)
                {
                    foreach (var alimSatim in alimSatims)
                    {

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
                    dataGridView1.DataSource = BuySellHistory;
                    //BuySellHistory.Clear();

                }
                else
                {
                    MessageBox.Show("Alım satım geçmişi bulunmamaktadır !");
                }


                if (dataGridView1.Rows.Count > 0)

                {

                    SaveFileDialog save = new SaveFileDialog();

                    save.Filter = "PDF (*.pdf)|*.pdf";

                    save.FileName = "Rapor.pdf";

                    bool ErrorMessage = false;

                    if (save.ShowDialog() == DialogResult.OK)

                    {

                        if (File.Exists(save.FileName))

                        {

                            try

                            {

                                File.Delete(save.FileName);

                            }

                            catch (Exception ex)

                            {

                                ErrorMessage = true;

                                MessageBox.Show("Dosya diske yazılamadı !" + ex.Message);

                            }

                        }

                        if (!ErrorMessage)

                        {

                            try

                            {

                                PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);

                                pTable.DefaultCell.Padding = 2;

                                pTable.WidthPercentage = 100;

                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn col in dataGridView1.Columns)

                                {

                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                    pTable.AddCell(pCell);

                                }

                                foreach (DataGridViewRow viewRow in dataGridView1.Rows)

                                {

                                    foreach (DataGridViewCell dcell in viewRow.Cells)

                                    {

                                        pTable.AddCell(dcell.Value.ToString());

                                    }

                                }

                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                                {

                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                    PdfWriter.GetInstance(document, fileStream);

                                    document.Open();

                                    document.Add(pTable);

                                    document.Close();

                                    fileStream.Close();

                                }

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
