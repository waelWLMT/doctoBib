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
    /// The specialite read repository.
    /// </summary>
    public class SpecialiteReadRepository : ReadRepository<Specialite>, ISpecialiteReadRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialiteReadRepository"/> class.
        /// </summary>
        /// <param name="mydbContext">The mydb context.</param>
        public SpecialiteReadRepository(MyDbContext mydbContext) : base(mydbContext)
        {
        }

    }
}
