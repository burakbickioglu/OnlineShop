using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IKullaniciService: IBaseService<Kullanici>
    {
        Kullanici UserControl(string kullaniciad, string sifre);
        Kullanici Get(Kullanici kullanici);
    }
}
