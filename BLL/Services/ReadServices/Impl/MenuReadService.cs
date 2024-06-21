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
    /// The menu read service.
    /// </summary>
    public class MenuReadService : ReadServicePattern<Menu>, IMenuReadService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuReadService"/> class.
        /// </summary>
        /// <param name="menuReadRepository">The menu read repository.</param>
        public MenuReadService(IMenuReadRepository menuReadRepository) : base(menuReadRepository)
        {
        }
    }
}
