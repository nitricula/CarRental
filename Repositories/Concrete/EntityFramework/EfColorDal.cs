using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Abstract.EntityFramework;

namespace Repositories.Concrete.EntityFramework
{
    public class EfColorDal : EntityBaseRepository<Color, CarRentalContext>, IColorDal
    {
    }
}
