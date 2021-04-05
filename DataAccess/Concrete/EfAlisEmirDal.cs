using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfAlisEmirDal : EfRepositoryBase<AlisEmir, OnlineShopContext>, IAlisEmirDal
    {

    }
}
