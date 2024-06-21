using Core.Models;
using Data.RepositoryPatterns.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.WriteRepositories.Impl
{
    /// <summary>
    /// The calendrier repository.
    /// </summary>
    public class CalendrierRepository : Repository<Calendrier>, ICalendrierRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendrierRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The db context.</param>
        public CalendrierRepository(MyDbContext dbContext) : base(dbContext)
        {
        }
    }
}
