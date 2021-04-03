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

        public bool Add(Kullanici kullanici)
        {
            return _kullaniciDal.Add(kullanici);
        }

        public bool Delete(Kullanici kullanici)
        {
            return _kullaniciDal.Delete(kullanici);

        }

        public List<Kullanici> GetAll()
        {
            return _kullaniciDal.GetAll();
        }

        public Kullanici GetById(int id)
        {
            return _kullaniciDal.Get(p => p.KullaniciId == id);

        }

        public bool Update(Kullanici alimSatim)
        {
            return _kullaniciDal.Update(alimSatim);
        }
    }
}
