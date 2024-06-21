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
    /// The praticien read repository.
    /// </summary>
    public class PraticienReadRepository : ReadRepository<Praticien>, IPraticienReadRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PraticienReadRepository"/> class.
        /// </summary>
        /// <param name="mydbContext">The mydb context.</param>
        public PraticienReadRepository(MyDbContext mydbContext) : base(mydbContext)
        {
        }
    }
}
