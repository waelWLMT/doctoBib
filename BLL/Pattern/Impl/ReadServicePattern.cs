using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Pattern.Impl
{
    public class ReadServicePattern<T> : IReadServicePattern<T> where T : class
    {
        private readonly IReadRepository<T> _readRepository;

        public ReadServicePattern(IReadRepository<T> readRepository)
        {
            _readRepository = readRepository;
        }
        public List<T> GetAll()
        {
            return _readRepository.GetAll();
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            return _readRepository.FindBy(predicate, includes);
        }

        public T GetById(object id)
        {
            return _readRepository.Get(id);
        }
    }
}
