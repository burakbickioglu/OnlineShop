using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBaseService<T>
    {
        List<T> GetAll();
        T Get(T entity);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
