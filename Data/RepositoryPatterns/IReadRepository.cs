using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryPatterns
{
    public interface IReadRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(object id);
    }
}
