using System;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDal());
            Kullanici k = new Kullanici();
            k.Ad = "Burak";
            k.Soyad = "Biçkioğlu";
            k.KullaniciAd = "Bickique";
            k.KullaniciSifre = "1234";
            k.TelNo = "5380497078";
            var result = kullaniciManager.Add(k);
            Console.WriteLine("tamamdır");
        }
    }
}
