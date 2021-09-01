using Entities.Concrete;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public class BaseService<T,TDal>
        where T:class,IEntity,new()
        where TDal:class,IRepository<T>
    {
        protected TDal entityDal;

        public BaseService(TDal entityDal)
        {
            this.entityDal = entityDal;
        }

        public void Add(T entity)
        {
            entityDal.Add(entity);
        }

        public void Delete(T entity)
        {
            entityDal.Delete(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return entityDal.Get(filter);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return entityDal.GetAll(filter);
        }

        public void Update(T entity)
        {
             entityDal.Update(entity);
        }
    }
}
