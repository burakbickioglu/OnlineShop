using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class EfRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        // Bu sınıf diğer dataacces sınıflarının base görevini üstlenen bir generic sınıftır. İlgili crud işlemlerini kalıtım alan diğer sınıfların da gerçekleştirebilmesini sağlar.

        // Entity framework ile add metodu aşağıdaki gibi gerçekleştirilmiştir.
        public bool Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
            return true;

        }

        // Entity framework ile delete metodu aşağıdaki gibi gerçekleştirilmiştir.
        public bool Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
            return true;

        }

        // Entity framework ile get metodu aşağıdaki gibi gerçekleştirilmiştir.
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        // Entity framework ile getall metodu aşağıdaki gibi gerçekleştirilmiştir.
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        // Entity framework ile update metodu aşağıdaki gibi gerçekleştirilmiştir.
        public bool Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var UpdatedEntity = context.Entry(entity);
                UpdatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
            return true;

        }
    }
}
