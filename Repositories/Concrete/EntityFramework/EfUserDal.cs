using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Abstract.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Concrete.EntityFramework
{
    public class EfUserDal:EntityBaseRepository<User,CarRentalContext>,IUserDal
    {

    }
}
