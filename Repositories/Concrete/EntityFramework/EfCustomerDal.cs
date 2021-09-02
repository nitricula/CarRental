using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Abstract.EntityFramework;

namespace Repositories.Concrete.EntityFramework
{
    public class EfCustomerDal : EntityBaseRepository<Customer, CarRentalContext>, ICustomerDal
    {

    }
}
