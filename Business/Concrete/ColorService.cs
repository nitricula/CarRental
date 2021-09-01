using Business.Abstract;
using Business.Abstract.EntityFramework;

using Entities.Concrete;
using Repositories.Abstract;

namespace Business.Concrete
{
    public class ColorService : BaseService<Color, IColorDal>,IColorService
    {
        public ColorService(IColorDal entityDal) : base(entityDal)
        {

        }
    }
}
