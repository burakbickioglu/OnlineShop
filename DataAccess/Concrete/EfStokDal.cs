﻿using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfStokDal : EfRepositoryBase<Stok, OnlineShopContext>, IStokDal
    {
    }
}
