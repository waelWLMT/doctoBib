using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Pattern
{
    public interface IServicePattern<T> where T : class
    {
        T Insert(T entity);
        List<T> InsertAll(List<T> entities);
        T Update(T entity);
        List<T> UpdateAll(List<T> entities);
        bool Delete(T entity);
        bool DeleteAll(List<T> entities);

    }
}
