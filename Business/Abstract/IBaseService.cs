using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBaseService<T>
    {
        // bu interface bütün iş servis sınıflarına kalıtım verip referanslarını tutmaktadır
        List<T> GetAll();
        T Get(T entity);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
