using System;
using System.Collections.Generic;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //UrunManager urunManager = new UrunManager(new EfUrunDal());
            //Urun urun = new Urun{UrunId = 1,UrunAd = "Ema"};
            //var result = urunManager.Delete(urun);


            //AlimSatimManager alimsatimmanager = new AlimSatimManager(new EfAlimSatimDal());
            //AlimSatim a = new AlimSatim { IslemId = 1,AliciId = 1000, SaticiId = 20, UrunId = 4, Miktar = 40, ToplamFiyat = 40 };
            //var result = alimsatimmanager.Delete(a);

            
            //BakiyeManager bakiyemanager = new BakiyeManager(new EfBakiyeDal());
            //Bakiye b = new Bakiye{KullaniciId = 4,MevcutBakiye = 100,EklenecekBakiye = 20,BakiyeOnay = true};
            //var result = bakiyemanager.Delete(b);


            //AlisEmirManager alis = new AlisEmirManager(new EfAlisEmirDal());
            //AlisEmir a = new AlisEmir{EmirId = 1,AliciId = 3,UrunId = 1,Miktar = 50,Durum = false};
            //var result = alis.Delete(a);

            IlanManager ilan = new IlanManager(new EfIlanDal());
            Ilan i = new Ilan{IlanId = 1,SaticiId = 1,UrunId = 3,Miktar = 500,BirimFiyat = 2,Durum = false};
            var result = ilan.Delete(i);
            if (result)
            {
                Console.WriteLine("Tammam");
            }

        }
    }
}
