using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Abstract.EntityFramework;

namespace Repositories.Concrete.EntityFramework
{
    public class EfRentalDal : EntityBaseRepository<Rental, CarRentalContext>, IRentalDal
    {

    }
}
