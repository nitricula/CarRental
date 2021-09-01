using Entities.Concrete;
using Entities.Concrete.Dtos;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Abstract.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repositories.Concrete.EntityFramework
{
    public class EfCarDal : EntityBaseRepository<Car, CarRentalContext>, ICarDal
    {

        public List<Car> GetCarsByBrandId(int id)
        {
            return this.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return this.GetAll(c => c.ColorId == id);
        }

        public List<CarDetailDto> GetCarsDetail(Expression<Func<Car, bool>> filter = null)
        {
            using (var context = new CarRentalContext())
            {
                List<CarDetailDto> result;
                if(filter==null)
                {
                    result= (from c in context.Cars
                            join b in context.Brands
                            on c.BrandId equals b.Id
                            join color in context.Colors
                            on c.ColorId equals color.Id
                            select new CarDetailDto
                            {
                                CarName = c.Name,
                                BrandName = b.Name,
                                ColorName = color.Name,
                                DailyPrice = c.DailyPrice
                            }).ToList();
                }
                else
                {
                 result=(from c in context.Cars.Where(filter)
                    join b in context.Brands
                    on c.BrandId equals b.Id
                    join color in context.Colors
                    on c.ColorId equals color.Id
                    select new CarDetailDto
                    {
                        CarName = c.Name,
                        BrandName = b.Name,
                        ColorName = color.Name,
                        DailyPrice = c.DailyPrice
                    }).ToList();
                }

                return result;           
                           
            }
        }
    }
}
