using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Services.Abstarct
{
    public interface IService<T>
        where T : class, IEntity, new()

    {

        IResult Add(T entity);
        IResult Delete(T entity);

        IResult Update(T entity);
        IDataResult<List<T>> GetAll(Expression<Func<T, bool>> filter = null);

        IDataResult<T> Get(Expression<Func<T, bool>> filter);
    }
}
