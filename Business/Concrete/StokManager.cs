﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StokManager : IStokService
    {
        IStokDal _stokDal;

        public StokManager(IStokDal stokDal)
        {
            _stokDal = stokDal;
        }
        public List<Stok> GetAll()
        {
            return _stokDal.GetAll();
        }

        public Stok GetById(int id)
        {
            return _stokDal.Get(p => p.StokKod == id);

        }

        public bool Add(Stok entity)
        {
            return _stokDal.Add(entity);
        }

        public bool Update(Stok entity)
        {
            return _stokDal.Update(entity);
        }

        public bool Delete(Stok entity)
        {
            return _stokDal.Delete(entity);
        }
    }
}