using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryPatterns.Impl
{
    /// <summary>
    /// The unit of work.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// The db context.
        /// </summary>
        private readonly MyDbContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="dbContext">The db context.</param>
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
