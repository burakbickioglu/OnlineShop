﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IAdminDal : IEntityRepository<Admin>
    {
    }
}
