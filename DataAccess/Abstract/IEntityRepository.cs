using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // Bu interface diğer Dal soyut sınıflarının base görevini üstlenir
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    
    }
}
