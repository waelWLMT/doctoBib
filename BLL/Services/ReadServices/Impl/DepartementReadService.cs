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
    /// The departement read service.
    /// </summary>
    public class DepartementReadService : ReadServicePattern<Departement>, IDepartementReadService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartementReadService"/> class.
        /// </summary>
        /// <param name="departementReadRepository">The departement read repository.</param>
        public DepartementReadService(IDepartementReadRepository departementReadRepository) : base(departementReadRepository)
        {
        }
    }
}
