using Business.Abstract.Mem;
using Entities.Concrete;
using Repositories.Abstract;

namespace Business.Concrete
{
    public class BrandService : BaseService<Brand, IBrandDal>
    {
        public BrandService(IBrandDal entityDal) : base(entityDal)
        {

        }
    }
}
