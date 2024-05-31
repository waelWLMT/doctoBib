using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryPatterns.Impl
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {
        protected readonly MyDbContext _dbContext;    
        protected readonly DbSet<T> _dbSet;
        public ReadRepository(MyDbContext mydbContext)
        {
            _dbContext = mydbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public virtual T Get(object id)
        {
            if (id == null)
                throw new ArgumentException("id ne doit pas avoir une valeur null");

            return _dbSet.Find(id);
           
        }

        public virtual List<T> GetAll()
        {
            return _dbSet.ToList();
        }
    
    }
}
