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
    /// The adresse read service.
    /// </summary>
    public class AdresseReadService : ReadServicePattern<Adresse>, IAdresseReadService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdresseReadService"/> class.
        /// </summary>
        /// <param name="adresseReadRepository">The adresse read repository.</param>
        public AdresseReadService(IAdresseReadRepository adresseReadRepository) : base(adresseReadRepository)
        {
        }
    }
}
