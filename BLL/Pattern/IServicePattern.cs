using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Pattern
{
    public interface IServicePattern<T> where T : class
    {
        #region Synchronous 
        T Insert(T entity);
        List<T> InsertAll(List<T> entities);
        T Update(T entity);
        List<T> UpdateAll(List<T> entities);
        bool Delete(T entity);
        bool DeleteAll(List<T> entities);

        #endregion

        #region Asynchronous 
        Task<T> InsertAsync(T entity);
        Task<List<T>> InsertAllAsync(List<T> entities);
        Task<T> UpdateAsync(T entity);
        Task<List<T>> UpdateAllAsync(List<T> entities);
        Task<bool> DeleteAsync(T entity);
        Task<bool> DeleteAllAsync(List<T> entities);

        #endregion

    }
}
