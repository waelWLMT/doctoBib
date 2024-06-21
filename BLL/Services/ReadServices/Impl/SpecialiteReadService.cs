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
    /// The specialite read service.
    /// </summary>
    public class SpecialiteReadService : ReadServicePattern<Specialite>, ISpecialiteReadService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialiteReadService"/> class.
        /// </summary>
        /// <param name="specialiteReadRepository">The specialite read repository.</param>
        public SpecialiteReadService(ISpecialiteReadRepository specialiteReadRepository) : base(specialiteReadRepository)
        {
        }

    }
}
