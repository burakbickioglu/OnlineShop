using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AlimSatimManager : IAlimSatimService
    {
        private IAlimSatimDal _alimSatim;
        // Dependency injection ile constructor aracılığıyla bir IAlimSatimDal kalıtımı alan nesne bu sınıfa gönderilir.
        public AlimSatimManager(IAlimSatimDal alimSatim)
        {
            _alimSatim = alimSatim;
        }
        // tüm kayıtların listelenmesi için ilgili managerin getall metodu çağrılır
        public List<AlimSatim> GetAll()
        {
            return _alimSatim.GetAll();
        }

        // alınan parametreye göre tek bir kaydın dönmesi için ilgili managerin get metodu çağrılır
        public AlimSatim Get(AlimSatim entity)
        {
            return _alimSatim.Get(p => p.IslemId == entity.IslemId);
        }

        //  alınan parametre nesnesinin veritabanına eklenmesi için ilgili managerin add metodu çağrılır
        public bool Add(AlimSatim entity)
        {
            return _alimSatim.Add(entity);
        }

        //  alınan parametre nesnesinin güncellenmesi için ilgili managerin update metodu çağrılır
        public bool Update(AlimSatim entity)
        {
            return _alimSatim.Update(entity);
        }

        //  alınan parametre nesnesinin veritabanından silinmesi için ilgili managerin delete metodu çağrılır
        public bool Delete(AlimSatim entity)
        {
            return _alimSatim.Delete(entity);
        }
    }
}
