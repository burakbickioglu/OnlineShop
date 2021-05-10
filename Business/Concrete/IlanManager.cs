using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class IlanManager : IIlanService
    {
        private IIlanDal _IlanDal;

        // Dependency injection ile constructor aracılığıyla bir IIlanDal kalıtımı alan nesne bu sınıfa gönderilir.
        public IlanManager(IIlanDal IlanDal)
        {
            _IlanDal = IlanDal;
        }

        // tüm kayıtların listelenmesi için ilgili managerin getall metodu çağrılır
        public List<Ilan> GetAll()
        {
            return _IlanDal.GetAll();
        }

        // alınan parametreye göre tek bir kaydın dönmesi için ilgili managerin get metodu çağrılır
        public Ilan Get(Ilan entity)
        {
            return _IlanDal.Get(p => p.IlanId == entity.IlanId);
        }

        //  alınan parametre nesnesinin veritabanına eklenmesi için ilgili managerin add metodu çağrılır
        public bool Add(Ilan entity)
        {
            return _IlanDal.Add(entity);
        }

        //  alınan parametre nesnesinin güncellenmesi için ilgili managerin update metodu çağrılır
        public bool Update(Ilan entity)
        {
            return _IlanDal.Update(entity);
        }

        //  alınan parametre nesnesinin veritabanından silinmesi için ilgili managerin delete metodu çağrılır
        public bool Delete(Ilan entity)
        {
            return _IlanDal.Delete(entity);
        }
    }
}
