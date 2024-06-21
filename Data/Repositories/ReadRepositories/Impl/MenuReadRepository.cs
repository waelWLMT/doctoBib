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
    /// The menu read repository.
    /// </summary>
    public class MenuReadRepository : ReadRepository<Menu>, IMenuReadRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuReadRepository"/> class.
        /// </summary>
        /// <param name="mydbContext">The mydb context.</param>
        public MenuReadRepository(MyDbContext mydbContext) : base(mydbContext)
        {
        }

    }
}
