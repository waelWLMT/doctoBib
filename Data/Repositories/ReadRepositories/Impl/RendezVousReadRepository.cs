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
    /// The rendez vous read repository.
    /// </summary>
    public class RendezVousReadRepository : ReadRepository<RendezVous>, IRendezVousReadRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RendezVousReadRepository"/> class.
        /// </summary>
        /// <param name="mydbContext">The mydb context.</param>
        public RendezVousReadRepository(MyDbContext mydbContext) : base(mydbContext)
        {
        }
    }
}
