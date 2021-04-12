using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IStokService : IBaseService<Stok>
    {
        List<UserStockDto> GetUserStockDetail(Kullanici kullanici);

    }
}
