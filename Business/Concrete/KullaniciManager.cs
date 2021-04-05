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

        public List<Kullanici> GetAll()
        {
            return _kullaniciDal.GetAll();
        }

        public Kullanici GetById(int id)
        {
            return _kullaniciDal.Get(p => p.KullaniciId == id);

        }

        public bool Update(Kullanici entity)
        {
            return _kullaniciDal.Update(entity);
        }
    }
}
