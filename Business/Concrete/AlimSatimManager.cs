using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AlimSatimManager : IAlimSatimService
    {
        private IAlimSatimDal _alimSatim;

        public AlimSatimManager(IAlimSatimDal alimSatim)
        {
            _alimSatim = alimSatim;
        }

        public List<AlimSatim> GetAll()
        {
            return _alimSatim.GetAll();
        }

        public AlimSatim GetById(int id)
        {
            return _alimSatim.Get(p => p.IslemId == id);
        }

        public bool Add(AlimSatim entity)
        {
            return _alimSatim.Add(entity);
        }

        public bool Update(AlimSatim entity)
        {
            return _alimSatim.Update(entity);
        }

        public bool Delete(AlimSatim entity)
        {
            return _alimSatim.Delete(entity);
        }
    }
}
