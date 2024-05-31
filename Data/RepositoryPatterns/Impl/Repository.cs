using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryPatterns.Impl
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly MyDbContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public Repository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity) + "ne doit pas etre null");

            _dbSet.Remove(entity);
        }
        public void DeleteAll(List<T> entities)
        {
            if (entities == null || !entities.Any())
                throw new ArgumentNullException(nameof(entities) + "ne doit pas etre ni null ni vide");

            _dbSet.RemoveRange(entities);            
        }

        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity) + "ne doit pas etre null");
            _dbSet.Add(entity);

        }
        public void InsertAll(List<T> entities)
        {
            _dbSet.AddRange(entities);
        }
        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity) + " ne doit pas etre null");
        }


    }
}
