using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Abstract
{
    public interface ICarDal:IRepository<Car>
    {
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
    }
}
