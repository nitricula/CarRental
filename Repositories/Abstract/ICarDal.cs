using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Repositories.Abstract
{
    public interface ICarDal:IRepository<Car>
    {
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);

        List<CarDetailDto> GetCarsDetail(Expression<Func<Car, bool>> filter = null);
    }
}
