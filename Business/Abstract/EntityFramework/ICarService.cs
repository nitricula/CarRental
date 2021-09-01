using Core.Services.Abstarct;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract.EntityFramework
{
    public interface ICarService : IService<Car>
    {
        List<CarDetailDto> GetCarDetailDtos(Expression<Func<Car, bool>> filter = null);
    }
}
