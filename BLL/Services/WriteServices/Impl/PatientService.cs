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
    /// The patient service.
    /// </summary>
    public class PatientService : ServicePattern<Patient>, IPatientService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="unitOfWork">The unit of work.</param>
        public PatientService(IPatientRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
