using BLL.Pattern.Impl;
using Core.Models;
using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ReadServices.Impl
{
    /// <summary>
    /// The user read service.
    /// </summary>
    public class UserReadService : ReadServicePattern<User>, IUserReadService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserReadService"/> class.
        /// </summary>
        /// <param name="readRepository">The read repository.</param>
        public UserReadService(IReadRepository<User> readRepository) : base(readRepository) { }

    }
}
