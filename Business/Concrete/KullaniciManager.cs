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


        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public bool Add(Kullanici entity)
        {

            return _kullaniciDal.Add(entity);
        }

        public bool Delete(Kullanici entity)
        {
            return _kullaniciDal.Delete(entity);

        }

        public Kullanici UserControl(string kullaniciad, string sifre)
        {
            return _kullaniciDal.Get(p => p.KullaniciAd == kullaniciad && p.KullaniciSifre == sifre);
        }

        public Kullanici getById(Kullanici kullanici)
        {
            return _kullaniciDal.Get(p => p.KullaniciId == kullanici.KullaniciId);
        }

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
