using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryPatterns
{
    public interface IRepository<T> where T : class
    {
        #region Synchronous
        T Insert(T entity);
        List<T> InsertAll(List<T> entities); 
        bool Delete(T entity);
        bool DeleteAll(List<T> entities);
        T Update(T entity);

        #endregion

      
      
    }
}
