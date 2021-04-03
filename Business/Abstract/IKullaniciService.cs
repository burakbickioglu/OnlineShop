using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IKullaniciService
    {
        List<Kullanici> GetAll();
        Kullanici GetById(int id);
        bool Add(Kullanici kullanici);
        bool Update(Kullanici kullanici);
        bool Delete(Kullanici kullanici);
    }
}
