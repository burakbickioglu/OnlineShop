using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UrunManager : IUrunService
    {
        IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        public List<Urun> GetAll()
        {
            return _urunDal.GetAll();
        }

        public Urun GetById(int id)
        {
            return _urunDal.Get(p => p.UrunId == id);
        }

        public bool Add(Urun entity)
        {
            return _urunDal.Add(entity);
        }

        public bool Update(Urun entity)
        {
            return _urunDal.Update(entity);
        }

        public bool Delete(Urun entity)
        {
            return _urunDal.Delete(entity);
        }
    }
}
