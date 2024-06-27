using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryPatterns
{
    public interface IReadRepository<T> where T : class
    {

        #region Synchronous 
        List<T> GetAll();
        T Get(object id);
        List<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

        #endregion

        #region Asynchronous 

        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(object id);
        Task<List<T>> FindByAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

        #endregion

    }
}
