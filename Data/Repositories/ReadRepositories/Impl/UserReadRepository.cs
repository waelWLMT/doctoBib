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
    /// The user read repository.
    /// </summary>
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserReadRepository"/> class.
        /// </summary>
        /// <param name="mydbContext">The mydb context.</param>
        public UserReadRepository(MyDbContext mydbContext) : base(mydbContext) { }
    }
}
