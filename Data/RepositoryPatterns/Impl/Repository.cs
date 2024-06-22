using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryPatterns.Impl
{
    /// <summary>
    /// The repository.
    /// </summary>
    /// <typeparam name="T"/>
    public class Repository<T> : IRepository<T> where T : class
    {
        /// <summary>
        /// The db context.
        /// </summary>
        protected readonly MyDbContext _dbContext;
        /// <summary>
        /// The db set.
        /// </summary>
        protected readonly DbSet<T> _dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository"/> class.
        /// </summary>
        /// <param name="dbContext">The db context.</param>
        public Repository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }


        #region Synchronous
        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity) + "ne doit pas etre null");
            _dbSet.Add(entity);

        }
        /// <summary>
        /// Inserts the all.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void InsertAll(List<T> entities)
        {
            _dbSet.AddRange(entities);
        }
        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity) + " ne doit pas etre null");
        }
        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity) + "ne doit pas etre null");

            _dbSet.Remove(entity);
        }
        /// <summary>
        /// Deletes the all.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void DeleteAll(List<T> entities)
        {
            if (entities == null || !entities.Any())
                throw new ArgumentNullException(nameof(entities) + "ne doit pas etre ni null ni vide");

            _dbSet.RemoveRange(entities);            
        }

        #endregion

    }
}
