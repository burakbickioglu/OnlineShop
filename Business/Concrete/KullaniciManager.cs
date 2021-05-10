using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;

        // Dependency injection ile constructor aracılığıyla bir IKullaniciDal kalıtımı alan nesne bu sınıfa gönderilir.
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        // tüm kayıtların listelenmesi için ilgili managerin getall metodu çağrılır
        public bool Add(Kullanici entity)
        {

            return _kullaniciDal.Add(entity);
        }

        //  alınan parametre nesnesinin veritabanından silinmesi için ilgili managerin delete metodu çağrılır
        public bool Delete(Kullanici entity)
        {
            return _kullaniciDal.Delete(entity);

        }

        // İlgili kullanıcının kontrol edilmesi için ilgili managerin get metodu çağrılır
        public Kullanici UserControl(string kullaniciad, string sifre)
        {
            return _kullaniciDal.Get(p => p.KullaniciAd == kullaniciad && p.KullaniciSifre == sifre);
        }

        public Kullanici getById(Kullanici kullanici)
        {
            return _kullaniciDal.Get(p => p.KullaniciId == kullanici.KullaniciId);
        }

        // alınan parametreye göre tek bir kaydın dönmesi için ilgili managerin get metodu çağrılır
        public Kullanici Get(Kullanici kullanici)
        {
            return _kullaniciDal.Get(p => p.KullaniciAd == kullanici.KullaniciAd);
            
        }

        public List<Kullanici> GetAll()
        {
            return _kullaniciDal.GetAll();
        }

        

        public bool Update(Kullanici entity)
        {
            return _kullaniciDal.Update(entity);
        }
    }
}
