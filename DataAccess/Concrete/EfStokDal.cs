using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class EfStokDal : EfRepositoryBase<Stok, OnlineShopContext>, IStokDal
    {

        public List<UserStockDto> GetUserStockDetail(Kullanici kullanici)
        {
            using (OnlineShopContext context = new OnlineShopContext())
            {
                var result = from k in context.tblKullanici
                    join s in context.tblStok on k.KullaniciId equals s.KullaniciId
                    join u in context.tblUrun on s.UrunId equals u.UrunId
                    select new UserStockDto
                    {
                        KullaniciId = s.KullaniciId,
                        UrunAd = u.UrunAd,
                        UrunOnay = s.UrunOnay,
                        StokKod = s.StokKod,
                        UrunMiktar = s.UrunMiktar
                        
                    };
                
                return result.ToList();
            }
        }
    }
}
