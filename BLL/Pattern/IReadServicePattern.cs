using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Pattern
{
    public interface IReadServicePattern<T>  where T : class
    {
        T GetById(object id);
        List<T> GetAll();       
        List<T> GetAll(Expression <Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

    }
}
