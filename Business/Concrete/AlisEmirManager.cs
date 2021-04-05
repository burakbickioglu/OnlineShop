using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AlisEmirManager : IBaseService<AlisEmir>
    {
        private IAlisEmirDal _alisEmirDal;

        public AlisEmirManager(IAlisEmirDal alisEmirDal)
        {
            _alisEmirDal = alisEmirDal;
        }

        public List<AlisEmir> GetAll()
        {
            return _alisEmirDal.GetAll();
        }

        public AlisEmir GetById(int id)
        {
            return _alisEmirDal.Get(p => p.EmirId == id);
        }

        public bool Add(AlisEmir entity)
        {
            return _alisEmirDal.Add(entity);
        }

        public bool Update(AlisEmir entity)
        {
            return _alisEmirDal.Update(entity);
        }

        public bool Delete(AlisEmir entity)
        {
            return _alisEmirDal.Delete(entity);
        }
    }
}
