using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class DovizManager : IDovizService
    {
        IDovizDal _dovizDal;

        public DovizManager(IDovizDal dovizDal)
        {
            _dovizDal = dovizDal;
        }
        public List<Doviz> GetAll()
        {
            return _dovizDal.GetAll();
        }

        public Doviz Get(Doviz entity)
        {
            return _dovizDal.Get(p => p.DovizId == entity.DovizId);
        }

        public Doviz GetByName(string name)
        {
            return _dovizDal.Get(p => p.DovizAd == name);
        }

        public bool Add(Doviz entity)
        {
            return _dovizDal.Add(entity);
        }

        public bool Update(Doviz entity)
        {
            return _dovizDal.Update(entity);
        }

        public bool Delete(Doviz entity)
        {
            return _dovizDal.Delete(entity);
            
        }
    }
}
