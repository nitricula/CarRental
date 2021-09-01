using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repositories.Abstract.EntityFramework
{
    public class EntityBaseRepository<TEntity, TContext> : IEntityRepository<TEntity, TContext>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var Entry = context.Entry(entity);
                Entry.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var Entry = context.Entry(entity);
                Entry.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var Entry = context.Entry(entity);
                Entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                var r = context.Set<TEntity>().ToList();
                return r;
                //return filter == null ?
                //    context.Set<Car>().ToList() :
                //    context.Set<Car>().Where(filter).ToList();
            }
        }
    }
}
