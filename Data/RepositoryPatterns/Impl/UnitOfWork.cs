using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryPatterns.Impl
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _dbContext;

        public UnitOfWork(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
        
        public void Rollback()
        {
            _dbContext.Dispose();
        }
    
    }
}
