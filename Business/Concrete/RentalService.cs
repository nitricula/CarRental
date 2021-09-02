
using Business.Abstract.EntityFramework;
using Core.Services.Abstarct;
using Entities.Concrete;
using Repositories.Abstract;

namespace Business.Concrete
{
    public class RentalService : BaseService<Rental, IRentalDal>, IRentalService
    {
        public RentalService(IRentalDal entityDal) : base(entityDal)
        {

        }
    }
}
