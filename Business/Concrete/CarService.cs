using Business.Abstract;
using Business.Abstract.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using Repositories.Abstract;
using Repositories.Concrete.IMem;
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
           if(MinimumNameCheck(entity)&&MinimumPriceCheck(entity)) 
                entityDal.Add(entity);
        }

        

        public void Update(Car entity)
        {
            entityDal.Update(entity);
        }
        public List<CarDetailDto> GetCarDetailDtos(Expression<Func<Car, bool>> filter = null)
        {
            return entityDal.GetCarsDetail(filter);
        }
        private bool MinimumPriceCheck(Car entity)
        {
            if (entity.DailyPrice > 0)
                return true;
            throw new Exception("Product must be greater than 0");
        }

        private bool MinimumNameCheck(Car entity)
        {
            if (entity.Name.Length >= 2)
                return true;
            throw new Exception("Product must be longer than 1 character.");
        }

        
    }
}
