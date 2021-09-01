using Business.Abstract.Mem;
using Entities.Concrete;
using Repositories.Abstract;

namespace Business.Concrete
{
    public class ColorService : BaseService<Color, IColorDal>
    {
        public ColorService(IColorDal entityDal) : base(entityDal)
        {

        }
    }
}
