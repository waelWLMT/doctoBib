using BLL.Pattern.Impl;
using Core.Models;
using Data.Repositories.ReadRepositories;
using Data.RepositoryPatterns;
using Data.RepositoryPatterns.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ReadServices.Impl
{
    /// <summary>
    /// The praticien read service.
    /// </summary>
    public class PraticienReadService : ReadServicePattern<Praticien>, IPraticienReadService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PraticienReadService"/> class.
        /// </summary>
        /// <param name="praticienReadRepository">The praticien read repository.</param>
        public PraticienReadService(IPraticienReadRepository praticienReadRepository) : base(praticienReadRepository)
        {
        }

    }
}
