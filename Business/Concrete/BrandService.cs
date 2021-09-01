
using Business.Abstract.EntityFramework;
using Core.Services.Abstarct;
using Entities.Concrete;
using Repositories.Abstract;

namespace Business.Concrete
{
    public class BrandService : BaseService<Brand, IBrandDal>,IBrandService
    {
        public BrandService(IBrandDal entityDal) : base(entityDal)
        {

        }
    }
}
