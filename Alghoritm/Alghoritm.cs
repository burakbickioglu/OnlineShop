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


            List<Ilan> tumIlanlar = new List<Ilan>();
            List<AlisEmir> alicilar = new List<AlisEmir>();
            Kullanici alici = new Kullanici();
            Kullanici satici = new Kullanici();
            Bakiye aliciBakiye = new Bakiye();
            Bakiye saticiBakiye = new Bakiye();
            Stok aliciStok = new Stok();


            IlanManager ilanManager = new IlanManager(new EfIlanDal());
            AlisEmirManager alisEmirManager = new AlisEmirManager(new EfAlisEmirDal());
            KullaniciManager kullaniManager = new KullaniciManager(new EfKullaniciDal());
            BakiyeManager bakiyeManager = new BakiyeManager(new EfBakiyeDal());
            StokManager stokManager = new StokManager(new EfStokDal());
            AlimSatimManager alimSatimManager = new AlimSatimManager(new EfAlimSatimDal());

            alicilar = alisEmirManager.GetAll().Where(p => p.Durum == false).ToList();
            if (alicilar.Count != 0)
            {
                foreach (var mevcutalici in alicilar)
                {
                    int toplamsatilanstok = 0;
                    int kontrol = 1;

                    tumIlanlar = ilanManager.GetAll().Where(p => p.Durum == false && p.UrunId == mevcutalici.UrunId).OrderBy(p => p.BirimFiyat).ToList();

                    foreach (var ilan in tumIlanlar)
                    {
                        toplamsatilanstok += ilan.Miktar;
                    }

                    alici = kullaniManager.getById(new Kullanici { KullaniciId = mevcutalici.AliciId });
                    aliciBakiye = bakiyeManager.Get(new Bakiye { KullaniciId = mevcutalici.AliciId });

                    while (mevcutalici.Miktar > 0 && toplamsatilanstok != 0)
                    {
                        foreach (var gecerliIlan in tumIlanlar)
                        {

                            aliciStok = stokManager.GetAll().SingleOrDefault(p =>
                                p.KullaniciId == mevcutalici.AliciId && p.UrunId == mevcutalici.UrunId);

                            saticiBakiye = bakiyeManager.Get(new Bakiye { KullaniciId = gecerliIlan.SaticiId });
                            AlimSatim alimSatim = new AlimSatim();

                            if (aliciBakiye.MevcutBakiye >= (gecerliIlan.Miktar * gecerliIlan.BirimFiyat) && alici.KullaniciId != gecerliIlan.SaticiId && gecerliIlan.Durum == false)
                            {
                                int alinanmiktar;
                                if (mevcutalici.Miktar >= gecerliIlan.Miktar)
                                {

                                    alinanmiktar = gecerliIlan.Miktar;
                                    toplamsatilanstok -= gecerliIlan.Miktar;
                                    mevcutalici.Miktar -= alinanmiktar;
                                    aliciBakiye.MevcutBakiye -= (alinanmiktar * gecerliIlan.BirimFiyat);
                                    saticiBakiye.MevcutBakiye += (alinanmiktar * gecerliIlan.BirimFiyat);
                                    aliciStok.UrunMiktar += alinanmiktar;
                                    aliciStok.UrunOnay = true;
                                    gecerliIlan.Miktar = 0;
                                    gecerliIlan.Durum = true;


                                    if (mevcutalici.Miktar == 0)
                                    {
                                        mevcutalici.Durum = true;
                                    }

                                    alimSatim.Miktar = alinanmiktar;

                                    bakiyeManager.Update(aliciBakiye);
                                    bakiyeManager.Update(saticiBakiye);
                                    stokManager.Update(aliciStok);
                                    ilanManager.Update(gecerliIlan);
                                    alisEmirManager.Update(mevcutalici);

                                    alimSatim.AliciId = alici.KullaniciId;
                                    alimSatim.SaticiId = gecerliIlan.SaticiId;
                                    alimSatim.UrunId = gecerliIlan.UrunId;
                                    alimSatim.ToplamFiyat = (alinanmiktar * gecerliIlan.BirimFiyat);
                                    alimSatimManager.Add(alimSatim);



                                }

                                else
                                {
                                    alinanmiktar = mevcutalici.Miktar;
                                    toplamsatilanstok -= mevcutalici.Miktar;
                                    gecerliIlan.Miktar -= alinanmiktar;
                                    aliciBakiye.MevcutBakiye -= (alinanmiktar * gecerliIlan.BirimFiyat);
                                    saticiBakiye.MevcutBakiye += (alinanmiktar * gecerliIlan.BirimFiyat);
                                    aliciStok.UrunMiktar += alinanmiktar;
                                    aliciStok.UrunOnay = true;
                                    mevcutalici.Miktar = 0;
                                    mevcutalici.Durum = true;

                                    alimSatim.Miktar = alinanmiktar;

                                    bakiyeManager.Update(aliciBakiye);
                                    bakiyeManager.Update(saticiBakiye);
                                    stokManager.Update(aliciStok);
                                    ilanManager.Update(gecerliIlan);
                                    alisEmirManager.Update(mevcutalici);


                                    alimSatim.AliciId = alici.KullaniciId;
                                    alimSatim.SaticiId = gecerliIlan.SaticiId;
                                    alimSatim.UrunId = gecerliIlan.UrunId;
                                    alimSatim.ToplamFiyat = (alinanmiktar * gecerliIlan.BirimFiyat);
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
