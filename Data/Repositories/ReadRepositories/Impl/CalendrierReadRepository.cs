using Core.Models;
using Data.RepositoryPatterns.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.ReadRepositories.Impl
{
    /// <summary>
    /// The calendrier read repository.
    /// </summary>
    public class CalendrierReadRepository : ReadRepository<Calendrier>, ICalendrierReadRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendrierReadRepository"/> class.
        /// </summary>
        /// <param name="mydbContext">The mydb context.</param>
        public CalendrierReadRepository(MyDbContext mydbContext) : base(mydbContext)
        {
        }
    }
}
