using System;
using System.Collections.Generic;
using System.Linq;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Alghoritm
{
    public class Alghoritm
    {
        public void alSat()
        {


            List<Ilan> tumIlanlar = new List<Ilan>();
            List<Ilan> uyanIlanlar = new List<Ilan>();
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

            alicilar = alisEmirManager.GetAll().Where(p => p.Durum == false).ToList();

            foreach (var mevcutalici in alicilar)
            {
                tumIlanlar = ilanManager.GetAll().Where(p => p.Durum == false && p.UrunId == mevcutalici.UrunId).OrderBy(p => p.BirimFiyat).ToList();


                alici = kullaniManager.Get(new Kullanici { KullaniciId = mevcutalici.AliciId });
                aliciBakiye = bakiyeManager.Get(new Bakiye { KullaniciId = alici.KullaniciId });

                while (mevcutalici.Miktar > 0)
                {
                    foreach (var gecerliIlan in tumIlanlar)
                    {
                        satici = kullaniManager.Get(new Kullanici { KullaniciId = gecerliIlan.SaticiId });

                        aliciStok = stokManager.GetAll().SingleOrDefault(p =>
                            p.KullaniciId == mevcutalici.AliciId && p.UrunId == mevcutalici.UrunId);

                        saticiBakiye = bakiyeManager.Get(new Bakiye { KullaniciId = gecerliIlan.SaticiId });


                        if (mevcutalici.Miktar >= gecerliIlan.Miktar)
                        {
                            if (aliciBakiye.MevcutBakiye >= (gecerliIlan.Miktar * gecerliIlan.BirimFiyat))
                            {
                                mevcutalici.Miktar -= gecerliIlan.Miktar;
                                aliciBakiye.MevcutBakiye -= (gecerliIlan.Miktar * gecerliIlan.BirimFiyat);
                                saticiBakiye.MevcutBakiye += (gecerliIlan.Miktar * gecerliIlan.BirimFiyat);
                                aliciStok.UrunMiktar += gecerliIlan.Miktar;
                                gecerliIlan.Miktar = 0;
                                gecerliIlan.Durum = true;
                                


                                if (mevcutalici.Miktar == 0)
                                {
                                    mevcutalici.Durum = true;
                                }

                                stokManager.Update(aliciStok);
                                ilanManager.Update(gecerliIlan);
                                alisEmirManager.Update(mevcutalici);
                            }
                        }
                        


                    }

                }




            }


        }
    }
}
