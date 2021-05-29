using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UrunManager : IUrunService
    {
        IUrunDal _urunDal;

        // Dependency injection ile constructor aracılığıyla bir IUrunDal kalıtımı alan nesne bu sınıfa gönderilir.
        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        // tüm kayıtların listelenmesi için ilgili managerin getall metodu çağrılır
        public List<Urun> GetAll()
        {
            return _urunDal.GetAll();
        }

        // alınan parametreye göre tek bir kaydın dönmesi için ilgili managerin get metodu çağrılır
        public Urun Get(Urun entity)
        {
            return _urunDal.Get(p => p.UrunAd == entity.UrunAd);
        }

        //  alınan parametre nesnesinin veritabanına eklenmesi için ilgili managerin add metodu çağrılır
        public bool Add(Urun entity)
        {
            return _urunDal.Add(entity);
        }

        //  alınan parametre nesnesinin güncellenmesi için ilgili managerin update metodu çağrılır
        public bool Update(Urun entity)
        {
            return _urunDal.Update(entity);
        }

        //  alınan parametre nesnesinin veritabanından silinmesi için ilgili managerin delete metodu çağrılır
        public bool Delete(Urun entity)
        {
            return _urunDal.Delete(entity);
        }

        public Urun getById(Urun urun)
        {
            return _urunDal.Get(p => p.UrunId == urun.UrunId);
        }
    }
}
