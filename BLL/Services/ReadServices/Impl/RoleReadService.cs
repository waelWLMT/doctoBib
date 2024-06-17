using BLL.Pattern.Impl;
using Core.Models;
using Data.Repositories.ReadRepositories;
using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ReadServices.Impl
{

    /// <summary>
    /// The role read service.
    /// </summary>
    public class RoleReadService : ReadServicePattern<Role>, IRoleReadService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleReadService"/> class.
        /// </summary>
        /// <param name="readRepository">The read repository.</param>
        public RoleReadService(IRoleReadRepository readRepository) : base(readRepository)
        {
        }
    }
}
