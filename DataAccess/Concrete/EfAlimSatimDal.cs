using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class EfAlimSatimDal : EfRepositoryBase<AlimSatim, OnlineShopContext>, IAlimSatimDal
    {
       
    }
}
