using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryPatterns.Impl
{
    /// <summary>
    /// The read repository.
    /// </summary>
    /// <typeparam name="T"/>
    public class ReadRepository<T> : IReadRepository<T> where T : class
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
        /// Initializes a new instance of the <see cref="ReadRepository"/> class.
        /// </summary>
        /// <param name="mydbContext">The mydb context.</param>
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

        /// <summary>
        /// Get the all.
        /// </summary>
        /// <returns><![CDATA[List<T>]]></returns>
        public virtual List<T> GetAll()
        {
            return _dbSet.ToList();
        }


        /// <summary>
        /// predicate est l'expression de la condition where
        /// includes est la liste des propriete à inclure avec l'entité recherchée  ( autrement dit c'est le filtre)
        /// un simple expemle d'utilisation de cette methode ==> userRepository.FindBy(x=> x.username == username, x.Roles);
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="includes">The includes.</param>
        /// <returns><![CDATA[List<T>]]></returns>
        public List<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = _dbSet.AsQueryable().Where(predicate);

            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToList();
        }

    }
}
