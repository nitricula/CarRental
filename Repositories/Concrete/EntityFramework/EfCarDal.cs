using Entities.Concrete;
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


    }
}
