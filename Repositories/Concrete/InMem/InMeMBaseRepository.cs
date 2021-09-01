using Entities.Concrete;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repositories.Concrete
{
    public class InMeMBaseRepository<Tentity>
        where Tentity:class,IEntity,new()        
    {
        protected List<Tentity> entityMem;

        public InMeMBaseRepository(List<Tentity> entityMem)
        {
            this.entityMem = entityMem;
        }

        public void Add(Tentity entity)
        {
            entityMem.Add(entity);
        }

        public void Delete(Tentity entity)
        {
            //gereksiz iş 
        } 
        
        public Tentity Get(Expression<Func<Tentity, bool>> filter)
        {
            return entityMem.SingleOrDefault(filter.Compile());
        }

        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            if (filter == null)
                return entityMem;
            return entityMem.Where(filter.Compile()).ToList();
        }

       
    }
}
