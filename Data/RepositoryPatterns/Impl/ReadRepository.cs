using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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


        /// <summary>
        /// predicate est l'expression de la condition where
        /// includes est la liste des propriete à inclure avec l'entité recherchée  ( autrement dit c'est le filtre)
        /// un simple expemle d'utilisation de cette methode ==> userRepository.FindBy(x=> x.username == username, x.Roles);
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public List<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = _dbSet.AsQueryable().Where(predicate);

            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToList();
        }

    }
}
