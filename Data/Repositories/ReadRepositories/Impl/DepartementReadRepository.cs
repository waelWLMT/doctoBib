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
    /// The departement read repository.
    /// </summary>
    public class DepartementReadRepository : ReadRepository<Departement>, IDepartementReadRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartementReadRepository"/> class.
        /// </summary>
        /// <param name="mydbContext">The mydb context.</param>
        public DepartementReadRepository(MyDbContext mydbContext) : base(mydbContext)
        {
        }
    }
}
