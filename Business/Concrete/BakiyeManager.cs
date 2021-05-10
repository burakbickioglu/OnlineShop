using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BakiyeManager : IBakiyeService
    {
        private IBakiyeDal _bakiyeDal;

        // Dependency injection ile constructor aracılığıyla bir IBakiyeManager kalıtımı alan nesne bu sınıfa gönderilir.
        public BakiyeManager(IBakiyeDal bakiyeDal)
        {
            _bakiyeDal = bakiyeDal;
        }

        // tüm kayıtların listelenmesi için ilgili managerin getall metodu çağrılır
        public List<Bakiye> GetAll()
        {
            return _bakiyeDal.GetAll();
        }

        // alınan parametreye göre tek bir kaydın dönmesi için ilgili managerin get metodu çağrılır
        public Bakiye Get(Bakiye entity)
        {
            return _bakiyeDal.Get(p => p.KullaniciId == entity.KullaniciId);
        }

        //  alınan parametre nesnesinin veritabanına eklenmesi için ilgili managerin add metodu çağrılır
        public bool Add(Bakiye entity)
        {
            return _bakiyeDal.Add(entity);
        }

        //  alınan parametre nesnesinin güncellenmesi için ilgili managerin update metodu çağrılır
        public bool Update(Bakiye entity)
        {
            return _bakiyeDal.Update(entity);
        }

        //  alınan parametre nesnesinin veritabanından silinmesi için ilgili managerin delete metodu çağrılır
        public bool Delete(Bakiye entity)
        {
            return _bakiyeDal.Delete(entity);
        }

        
    }
}
