using Core.Models;
using Data.RepositoryPatterns.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.ReadRepositories.Impl
{
    /// <summary>
    /// The patient read repository.
    /// </summary>
    public class PatientReadRepository : ReadRepository<Patient>, IPatientReadRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientReadRepository"/> class.
        /// </summary>
        /// <param name="mydbContext">The mydb context.</param>
        public PatientReadRepository(MyDbContext mydbContext) : base(mydbContext)
        {
        }
    }
}
