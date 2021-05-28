using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAdminService : IBaseService<Admin>
    {
        Admin UserControl(string kullaniciad, string sifre);

    }
}
