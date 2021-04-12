using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IStokDal : IEntityRepository<Stok>
    {
        List<UserStockDto> GetUserStockDetail(Kullanici kullanici);
    }
}
