
using Business.Abstract.EntityFramework;
using Core.Services.Abstarct;
using Entities.Concrete;
using Repositories.Abstract;

namespace Business.Concrete
{
    public class UserService : BaseService<User, IUserDal>, IUserService
    {
        public UserService(IUserDal entityDal) : base(entityDal)
        {

        }
    }
}
