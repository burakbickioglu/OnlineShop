using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class StokManager : IStokService
    {
        IStokDal _stokDal;

        // Dependency injection ile constructor aracılığıyla bir IStokDal kalıtımı alan nesne bu sınıfa gönderilir.
        public StokManager(IStokDal stokDal)
        {
            _stokDal = stokDal;
        }

        // tüm kayıtların listelenmesi için ilgili managerin getall metodu çağrılır
        public List<Stok> GetAll()
        {
            return _stokDal.GetAll();
        }

        // alınan parametreye göre tek bir kaydın dönmesi için ilgili managerin get metodu çağrılır
        public Stok Get(Stok entity)
        {
            return _stokDal.Get(p => p.KullaniciId == entity.KullaniciId );

        }

        //  alınan parametre nesnesinin veritabanına eklenmesi için ilgili managerin add metodu çağrılır
        public bool Add(Stok entity)
        {
            return _stokDal.Add(entity);
        }

        //  alınan parametre nesnesinin güncellenmesi için ilgili managerin update metodu çağrılır
        public bool Update(Stok entity)
        {
            return _stokDal.Update(entity);
        }

        //  alınan parametre nesnesinin veritabanından silinmesi için ilgili managerin delete metodu çağrılır
        public bool Delete(Stok entity)
        {
            return _stokDal.Delete(entity);
        }

        //  alınan parametre nesnesinin stok detayları için ilgili managerin getuserstockdetail  metodu çağrılır
        public List<UserStockDto> GetUserStockDetail(Kullanici kullanici)
        {
            return _stokDal.GetUserStockDetail(kullanici);
        }
    }
}
