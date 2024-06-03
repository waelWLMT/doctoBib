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
        /// <summary>
        /// predicate est le filtre de la requete
        /// includes est la liste des proprieté à selectionner dans la requete
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        List<T> GetAll(Expression <Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

    }
}
