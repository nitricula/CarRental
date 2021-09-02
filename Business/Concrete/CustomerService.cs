
using Business.Abstract.EntityFramework;
using Core.Services.Abstarct;
using Entities.Concrete;
using Repositories.Abstract;

namespace Business.Concrete
{
    public class CustomerService : BaseService<Customer, ICustomerDal>, ICustomerService
    {
        public CustomerService(ICustomerDal entityDal) : base(entityDal)
        {

        }
    }
}
