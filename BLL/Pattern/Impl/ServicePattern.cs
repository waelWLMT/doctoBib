using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Pattern.Impl
{
    public class ServicePattern<T> : IServicePattern<T> where T : class
    {
       
        private readonly IRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

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

        public List<T> UpdateAll(List<T> entities)
        {
            _unitOfWork.Commit();
            return entities;
        }
    
    
    }
}
