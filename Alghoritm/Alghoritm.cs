using System;
using System.Collections.Generic;
using System.Linq;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Alghoritm
{
    public class Alghoritm
    {
        public void alSat()
        {

            // Kullanılacak nesneler ilgili sınıflardan türetildi
            List<Ilan> tumIlanlar = new List<Ilan>();
            List<AlisEmir> alicilar = new List<AlisEmir>();
            Kullanici alici = new Kullanici();
            Bakiye aliciBakiye = new Bakiye();
            Bakiye saticiBakiye = new Bakiye();
            Stok aliciStok = new Stok();
            Admin admin = new Admin();

            // Kullanılacak manager nesneler ilgili sınıflardan türetildi
            IlanManager ilanManager = new IlanManager(new EfIlanDal());
            AlisEmirManager alisEmirManager = new AlisEmirManager(new EfAlisEmirDal());
            KullaniciManager kullaniManager = new KullaniciManager(new EfKullaniciDal());
            BakiyeManager bakiyeManager = new BakiyeManager(new EfBakiyeDal());
            StokManager stokManager = new StokManager(new EfStokDal());
            AlimSatimManager alimSatimManager = new AlimSatimManager(new EfAlimSatimDal());
            AdminManager adminManager = new AdminManager(new EfAdminDal());

            // tüm alıcılar veritabanından bir listeye çekildi
            alicilar = alisEmirManager.GetAll().Where(p => p.Durum == false).ToList();

            // admin bilgisi çekildi
            admin = adminManager.Get(new Admin {AdminId = 1});
            
            // alıcı varsa aşağıdaki if şartına girilir, yok ise algoritma yorulmaz, çıkılır
            if (alicilar.Count != 0)
            {
                // her alıcı için aşağıdaki foreach döngüsü dönüyor
                foreach (var mevcutalici in alicilar)
                {
                    int toplamsatilanstok = 0;
                    

                    tumIlanlar = ilanManager.GetAll().Where(p => p.Durum == false && p.UrunId == mevcutalici.UrunId).OrderBy(p => p.BirimFiyat).ToList();

                    foreach (var ilan in tumIlanlar)
                    {
                        toplamsatilanstok += ilan.Miktar;
                    }

                    // alıcının bilgi ve bakiyeleri alici ve alicibakiye değişkenlerine aktarılıyor
                    alici = kullaniManager.getById(new Kullanici { KullaniciId = mevcutalici.AliciId });
                    aliciBakiye = bakiyeManager.Get(new Bakiye { KullaniciId = mevcutalici.AliciId });

                    bool uygunUrunKontrol = true;

                    // alıcının alacağı ürün olduğu sürece while döngüsü dönüyor
                    while (mevcutalici.Miktar > 0 && toplamsatilanstok != 0 && uygunUrunKontrol)
                    {
                        
                        // her ilan için aşağıdaki foreach döngüsü dönüyor
                        foreach (var gecerliIlan in tumIlanlar)
                        {
                            // alıcının stok bilgisi alicistok değişkenine aktarılıyor
                            aliciStok = stokManager.GetAll().SingleOrDefault(p =>
                                p.KullaniciId == mevcutalici.AliciId && p.UrunId == mevcutalici.UrunId);

                            // satıcının bakiyesi saticibakiye değişkenine aktarılıyor
                            saticiBakiye = bakiyeManager.Get(new Bakiye { KullaniciId = gecerliIlan.SaticiId });
                            AlimSatim alimSatim = new AlimSatim();
                            // eğer alıcının verdiği teklife uygun bir satış emri yok ise 
                            if (mevcutalici.TeklifFiyat < gecerliIlan.BirimFiyat)
                            {
                                uygunUrunKontrol = false;
                            }

                            decimal adminYuzdesi = 0.01m;
                            // eğer alıcının bakiyesi geçerli ilanın toplam fiyatından büyükse ve alıcıyla satıcı aynı kişi değilse aşağıdaki if şartına giriliyor
                            if (aliciBakiye.MevcutBakiye >= ((gecerliIlan.Miktar * gecerliIlan.BirimFiyat)*(1.01m)) && alici.KullaniciId != gecerliIlan.SaticiId && gecerliIlan.Durum == false && uygunUrunKontrol)
                            {
                                int alinanmiktar;
                                // eğer alıcının alacağı miktar geçerli ilanın miktarından fazla ise aşağıdaki döngü çalışır
                                if (mevcutalici.Miktar >= gecerliIlan.Miktar)
                                {
                                    // ilgili aktarımlar gerçekleştirilir
                                    alinanmiktar = gecerliIlan.Miktar;
                                    toplamsatilanstok -= gecerliIlan.Miktar;
                                    mevcutalici.Miktar -= alinanmiktar;
                                    aliciBakiye.MevcutBakiye -= (alinanmiktar * gecerliIlan.BirimFiyat);
                                    aliciBakiye.MevcutBakiye -= (alinanmiktar * gecerliIlan.BirimFiyat) * adminYuzdesi;
                                    admin.Bakiye += (alinanmiktar * gecerliIlan.BirimFiyat) * adminYuzdesi;
                                    saticiBakiye.MevcutBakiye += (alinanmiktar * gecerliIlan.BirimFiyat);
                                    aliciStok.UrunMiktar += alinanmiktar;
                                    aliciStok.UrunOnay = true;
                                    gecerliIlan.Miktar = 0;
                                    gecerliIlan.Durum = true;

                                    // alıcının alacağı miktar sıfıra eşitse yani bittiyse, alım emri kapatılır
                                    if (mevcutalici.Miktar == 0)
                                    {
                                        mevcutalici.Durum = true;
                                    }


                                    alimSatim.Miktar = alinanmiktar;

                                    // admin bakiyesi güncellenir
                                    adminManager.Update(admin);


                                    // alıcı ve satıcının bakiye ve stok bilgileri, ilgili ilan ve alım emirleri güncellenir
                                    bakiyeManager.Update(aliciBakiye);
                                    bakiyeManager.Update(saticiBakiye);
                                    stokManager.Update(aliciStok);
                                    ilanManager.Update(gecerliIlan);
                                    alisEmirManager.Update(mevcutalici);

                                    alimSatim.AliciId = alici.KullaniciId;
                                    alimSatim.SaticiId = gecerliIlan.SaticiId;
                                    alimSatim.UrunId = gecerliIlan.UrunId;
                                    alimSatim.ToplamFiyat = (alinanmiktar * gecerliIlan.BirimFiyat);
                                    alimSatim.Tarih = DateTime.Today;
                                    alimSatimManager.Add(alimSatim);



                                }
                                // alıcının alacağı ürün miktarı ilgili ilan miktarından fazla değilse else bloğu çalışır
                                else
                                {
                                    // ilgili aktarımlar gerçekleştirilir

                                    alinanmiktar = mevcutalici.Miktar;
                                    toplamsatilanstok -= mevcutalici.Miktar;
                                    gecerliIlan.Miktar -= alinanmiktar;
                                    aliciBakiye.MevcutBakiye -= (alinanmiktar * gecerliIlan.BirimFiyat);
                                    aliciBakiye.MevcutBakiye -= (alinanmiktar * gecerliIlan.BirimFiyat) * adminYuzdesi;
                                    // aracı olan admine komisyon ödemesi işlemi
                                    admin.Bakiye += (alinanmiktar * gecerliIlan.BirimFiyat) * adminYuzdesi;
                                    saticiBakiye.MevcutBakiye += (alinanmiktar * gecerliIlan.BirimFiyat);
                                    aliciStok.UrunMiktar += alinanmiktar;
                                    aliciStok.UrunOnay = true;
                                    mevcutalici.Miktar = 0;
                                    mevcutalici.Durum = true;


                                    alimSatim.Miktar = alinanmiktar;

                                    // admin bakiyesi güncellenir
                                    adminManager.Update(admin);


                                    // alıcı ve satıcının bakiye ve stok bilgileri, ilgili ilan ve alım emirleri güncellenir
                                    bakiyeManager.Update(aliciBakiye);
                                    bakiyeManager.Update(saticiBakiye);
                                    stokManager.Update(aliciStok);
                                    ilanManager.Update(gecerliIlan);
                                    alisEmirManager.Update(mevcutalici);


                                    alimSatim.AliciId = alici.KullaniciId;
                                    alimSatim.SaticiId = gecerliIlan.SaticiId;
                                    alimSatim.UrunId = gecerliIlan.UrunId;
                                    alimSatim.ToplamFiyat = (alinanmiktar * gecerliIlan.BirimFiyat);
                                    alimSatim.Tarih = DateTime.Today;
                                    alimSatimManager.Add(alimSatim);

                                }


                            }
                        }
                    }
                }
            }
        }
    }
}
