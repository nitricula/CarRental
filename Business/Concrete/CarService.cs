using Business.Abstract;
using Business.Abstract.EntityFramework;
using Core.Services.Abstarct;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete.Errors;
using Core.Utilities.Results.Concrete.Success;
using Core.Utilities.Ruler;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using Repositories.Abstract;

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarService:BaseService<Car,ICarDal>,ICarService
    {
        public CarService(ICarDal entityDal):base(entityDal)
        {

        }
        public void Add(Car entity)
        {
           IResult ruleresult = BusinessRuler.Test(MinimumNameCheck(entity), MinimumPriceCheck(entity));
           if(ruleresult.Success)
                entityDal.Add(entity);
            else
            {
                Console.WriteLine(ruleresult.Message);
            }
        }

        

        public void Update(Car entity)
        {
            entityDal.Update(entity);
        }
        public List<CarDetailDto> GetCarDetailDtos(Expression<Func<Car, bool>> filter = null)
        {
            return entityDal.GetCarsDetail(filter);
        }
        private IResult MinimumPriceCheck(Car entity)
        {
            if (entity.DailyPrice > 0)
                return new SuccessResult();
            return new ErrorResult("Product must be greater than 0");
        }

        private IResult MinimumNameCheck(Car entity)
        {
            if (entity.Name.Length >= 2)
                return new SuccessResult();
            return new ErrorResult("Product must be longer than 1 character.");
        }

        
    }
}
