using Entities.Concrete;
using Entities.Concrete.Dtos;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repositories.Concrete.IMem
{
    public class CarDal : InMeMBaseRepository<Car>, ICarDal
    {
        public CarDal(List<Car> carlist):base(carlist)
        {

        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return this.entityMem.FindAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return this.entityMem.FindAll(c => c.ColorId == id);
        }

        public List<CarDetailDto> GetCarsDetail(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            var updateCar=this.entityMem.SingleOrDefault(c => c.Id == entity.Id);

            updateCar.BrandId = entity.BrandId;
            updateCar.ColorId = entity.ColorId;
            updateCar.ModelYear = entity.ModelYear;
            updateCar.DailyPrice = entity.DailyPrice;
            updateCar.Description = entity.Description;
        }
    }
}
