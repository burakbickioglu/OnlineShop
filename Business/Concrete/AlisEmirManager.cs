using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AlisEmirManager : IBaseService<AlisEmir>
    {
        private IAlisEmirDal _alisEmirDal;
        // Dependency injection ile constructor aracılığıyla bir IAlisEmirDal kalıtımı alan nesne bu sınıfa gönderilir.
        public AlisEmirManager(IAlisEmirDal alisEmirDal)
        {
            _alisEmirDal = alisEmirDal;
        }

        // tüm kayıtların listelenmesi için ilgili managerin getall metodu çağrılır
        public List<AlisEmir> GetAll()
        {
            return _alisEmirDal.GetAll();
        }

        // alınan parametreye göre tek bir kaydın dönmesi için ilgili managerin get metodu çağrılır
        public AlisEmir Get(AlisEmir entity)
        {
            return _alisEmirDal.Get(p => p.AliciId == entity.AliciId);
        }

        //  alınan parametre nesnesinin veritabanına eklenmesi için ilgili managerin add metodu çağrılır
        public bool Add(AlisEmir entity)
        {
            return _alisEmirDal.Add(entity);
        }

        //  alınan parametre nesnesinin güncellenmesi için ilgili managerin update metodu çağrılır
        public bool Update(AlisEmir entity)
        {
            return _alisEmirDal.Update(entity);
        }

        //  alınan parametre nesnesinin veritabanından silinmesi için ilgili managerin delete metodu çağrılır
        public bool Delete(AlisEmir entity)
        {
            return _alisEmirDal.Delete(entity);
        }
    }
}
