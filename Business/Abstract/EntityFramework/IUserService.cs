using Core.Services.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract.EntityFramework
{
    public interface IUserService:IService<User>
    {
    }
}
