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
        void Insert(T entity);
        void InsertAll(List<T> entities); 
        void Delete(T entity);
        void DeleteAll(List<T> entities);
        void Update(T entity);

        #endregion

      
      
    }
}
