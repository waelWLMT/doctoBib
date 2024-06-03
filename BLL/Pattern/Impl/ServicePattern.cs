using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Pattern.Impl
{
    /// <summary>
    /// The service pattern.
    /// </summary>
    /// <typeparam name="T"/>
    public class ServicePattern<T> : IServicePattern<T> where T : class
    {

        /// <summary>
        /// The repository.
        /// </summary>
        private readonly IRepository<T> _repository;
        /// <summary>
        /// The unit of work.
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePattern"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="unitOfWork">The unit of work.</param>
        public ServicePattern(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
             _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public bool Delete(T entity)
        {
            _repository.Delete(entity);
            _unitOfWork.Commit();

            return true;
        }

        /// <summary>
        /// Deletes all.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>A bool</returns>
        public bool DeleteAll(List<T> entities)
        {
            _repository.DeleteAll(entities);
            _unitOfWork.Commit();

            return true;
        }

        public T Insert(T entity)
        {
            _repository.Insert(entity);
            _unitOfWork.Commit();

            return entity;
        }

        /// <summary>
        /// Inserts the all.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns><![CDATA[List<T>]]></returns>
        public List<T> InsertAll(List<T> entities)
        {
            _repository.InsertAll(entities);
            _unitOfWork.Commit();

            return entities;
        }

        public T Update(T entity)
        {
            _unitOfWork.Commit();
            return entity;
        }

        /// <summary>
        /// Update the all.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns><![CDATA[List<T>]]></returns>
        public List<T> UpdateAll(List<T> entities)
        {
            _unitOfWork.Commit();
            return entities;
        }
    
    
    }
}
