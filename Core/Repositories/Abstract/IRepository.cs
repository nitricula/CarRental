using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Repositories.Abstract
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Delete(T entity);

        void Update(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

    }
}
