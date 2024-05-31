using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public T GetById(object id)
        {
            return _readRepository.Get(id);
        }
    }
}
