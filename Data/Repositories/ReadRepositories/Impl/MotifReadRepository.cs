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
    /// The motif read repository.
    /// </summary>
    public class MotifReadRepository : ReadRepository<Motif>, IMotifReadRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MotifReadRepository"/> class.
        /// </summary>
        /// <param name="mydbContext">The mydb context.</param>
        public MotifReadRepository(MyDbContext mydbContext) : base(mydbContext)
        {
        }
    }
}
