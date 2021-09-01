using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Abstract.EntityFramework;

namespace Repositories.Concrete.EntityFramework
{
    public class EfBrandDal : EntityBaseRepository<Brand, CarRentalContext>, IBrandDal
    {
        
    }
}
