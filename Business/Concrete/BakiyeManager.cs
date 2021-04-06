using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BakiyeManager : IBakiyeService
    {
        private IBakiyeDal _bakiyeDal;

        public BakiyeManager(IBakiyeDal bakiyeDal)
        {
            _bakiyeDal = bakiyeDal;
        }


        public List<Bakiye> GetAll()
        {
            return _bakiyeDal.GetAll();
        }

        public Bakiye GetById(int id)
        {
            return _bakiyeDal.Get(p => p.KullaniciId == id);
        }

        public bool Add(Bakiye entity)
        {
            return _bakiyeDal.Add(entity);
        }

        public bool Update(Bakiye entity)
        {
            return _bakiyeDal.Update(entity);
        }

        public bool Delete(Bakiye entity)
        {
            return _bakiyeDal.Delete(entity);
        }

        
    }
}
