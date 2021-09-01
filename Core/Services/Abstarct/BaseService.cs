using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete.Success;
using Core.Utilities.Results.Concrete.Errors;
using Entities.Concrete;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Constants;

namespace Core.Services.Abstarct
{
    public class BaseService<T, TDal>
        where T : class, IEntity, new()
        where TDal : class, IRepository<T>
    {
        protected TDal entityDal;

        public BaseService(TDal entityDal)
        {
            this.entityDal = entityDal;
        }

        public IResult Add(T entity)
        {
            try
            {
                entityDal.Add(entity);
                return new SuccessResult(Messages.SuccessAddMessage);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.ErrorAddMessage);
            }
             
        }

        public IResult Delete(T entity)
        {
            try
            {
                entityDal.Delete(entity);
                return new SuccessResult(Messages.SuccessDeleteMessage);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.ErrorDeleteMessage);
            }
        }

        public IDataResult<T> Get(Expression<Func<T, bool>> filter)
        {
            try
            {
                var result= entityDal.Get(filter);
                return new SuccessDataResult<T>(result, Messages.SuccessGetMessage);
            }
            catch (Exception)
            {

                return new ErrorDataResult<T>(null, Messages.ErrorGetMessage);
            }
            
        }

        public IDataResult<List<T>> GetAll(Expression<Func<T, bool>> filter = null)
        {
            try
            {
               var result= entityDal.GetAll(filter);
                return new SuccessDataResult<List<T>>(result,Messages.SuccessGetMessage);
            }
            catch (Exception)
            {

                return new ErrorDataResult<List<T>>(null,Messages.ErrorGetMessage);
            }
            
        }

        public IResult Update(T entity)
        {
            try
            {
                entityDal.Update(entity);
                return new SuccessResult(Messages.SuccessDeleteMessage);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.ErrorDeleteMessage);
            }
        }
    }
}
