using BLL.Pattern.Impl;
using Core.Models;
using Data.Repositories.ReadRepositories;
using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ReadServices.Impl
{
    /// <summary>
    /// The patient read service.
    /// </summary>
    public class PatientReadService : ReadServicePattern<Patient>, IPatientReadService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientReadService"/> class.
        /// </summary>
        /// <param name="patientReadRepository">The patient read repository.</param>
        public PatientReadService(IPatientReadRepository patientReadRepository) : base(patientReadRepository)
        {
        }
    }
}
