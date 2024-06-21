using Core.Models;
using Data.RepositoryPatterns;
using Data.RepositoryPatterns.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.WriteRepositories.Impl
{
    /// <summary>
    /// The patient repository.
    /// </summary>
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The db context.</param>
        public PatientRepository(MyDbContext dbContext) : base(dbContext)
        {
        }

    }
}
