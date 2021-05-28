using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {

        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public List<Admin> GetAll()
        {
            return _adminDal.GetAll();
        }

        public Admin Get(Admin entity)
        {
            return _adminDal.Get(p => p.AdminId == entity.AdminId);
        }

        public bool Add(Admin entity)
        {
            return _adminDal.Add(entity);
        }

        public bool Update(Admin entity)
        {
            return _adminDal.Update(entity);
        }

        public bool Delete(Admin entity)
        {
            return _adminDal.Delete(entity);
        }

        public Admin UserControl(string kullaniciad, string sifre)
        {
            return _adminDal.Get(p => p.KullaniciAd == kullaniciad && p.KullaniciSifre == sifre);
        }
    }
}
