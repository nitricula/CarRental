using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Abstract.EntityFramework
{
    public interface IEntityRepository<T,TContext>:IRepository<T>
    {
    }
}
