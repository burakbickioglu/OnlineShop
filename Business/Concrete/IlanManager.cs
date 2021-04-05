using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class IlanManager : IIlanService
    {
        private IIlanDal _IlanDal;

        public IlanManager(IIlanDal IlanDal)
        {
            _IlanDal = IlanDal;
        }

        public List<Ilan> GetAll()
        {
            return _IlanDal.GetAll();
        }

        public Ilan GetById(int id)
        {
            return _IlanDal.Get(p => p.IlanId == id);
        }

        public bool Add(Ilan entity)
        {
            return _IlanDal.Add(entity);
        }

        public bool Update(Ilan entity)
        {
            return _IlanDal.Update(entity);
        }

        public bool Delete(Ilan entity)
        {
            return _IlanDal.Delete(entity);
        }
    }
}
