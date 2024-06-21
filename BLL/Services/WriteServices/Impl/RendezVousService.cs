using BLL.Pattern.Impl;
using Core.Models;
using Data.Repositories.WriteRepositories;
using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.WriteServices.Impl
{
    /// <summary>
    /// The rendez vous service.
    /// </summary>
    public class RendezVousService : ServicePattern<RendezVous>, IRendezVousService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RendezVousService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="unitOfWork">The unit of work.</param>
        public RendezVousService(IRendezVousRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
