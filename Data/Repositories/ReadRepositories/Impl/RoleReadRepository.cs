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
    /// The role read repository.
    /// </summary>
    public class RoleReadRepository : ReadRepository<Role>, IRoleReadRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleReadRepository"/> class.
        /// </summary>
        /// <param name="mydbContext">The mydb context.</param>
        public RoleReadRepository(MyDbContext mydbContext) : base(mydbContext)
        {
        }
    }
}
