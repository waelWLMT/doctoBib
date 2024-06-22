using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Pattern.Impl
{
    /// <summary>
    /// The read service pattern.
    /// </summary>
    /// <typeparam name="T"/>
    public class ReadServicePattern<T> : IReadServicePattern<T> where T : class
    {
        /// <summary>
        /// The read repository.
        /// </summary>
        private readonly IReadRepository<T> _readRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadServicePattern"/> class.
        /// </summary>
        /// <param name="readRepository">The read repository.</param>
        public ReadServicePattern(IReadRepository<T> readRepository)
        {
            _readRepository = readRepository;
        }

        #region Synchronous

        /// <summary>
        /// Get the all.
        /// </summary>
        /// <returns><![CDATA[List<T>]]></returns>
        public List<T> GetAll()
        {
            return _readRepository.GetAll();
        }

        /// <summary>
        /// Get the all by generci filter and list of includes.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="includes">The includes.</param>
        /// <returns><![CDATA[List<T>]]></returns>
        public List<T> GetAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            return _readRepository.FindBy(predicate, includes);
        }

        /// <summary>
        /// Get by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>A T</returns>
        public T GetById(object id)
        {
            return _readRepository.Get(id);
        }

        #endregion

        #region Asynchronous

        /// <summary>
        /// Get by id asynchronously.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns><![CDATA[Task<T>]]></returns>
        public async Task<T> GetByIdAsync(object id)
        {
            return await _readRepository.GetAsync(id);
        }

        /// <summary>
        /// Get the all asynchronously.
        /// </summary>
        /// <returns><![CDATA[Task<List<T>>]]></returns>
        public async Task<List<T>> GetAllAsync()
        {
            return await _readRepository.GetAllAsync();
        }

        /// <summary>
        /// Get the all asynchronously.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="includes">The includes.</param>
        /// <returns><![CDATA[Task<List<T>>]]></returns>
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            return await _readRepository.FindByAsync(predicate, includes);
        }


        #endregion

    }
}
