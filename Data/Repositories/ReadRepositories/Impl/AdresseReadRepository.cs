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
    /// The adresse read repository.
    /// </summary>
    public class AdresseReadRepository : ReadRepository<Adresse>, IAdresseReadRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdresseReadRepository"/> class.
        /// </summary>
        /// <param name="mydbContext">The mydb context.</param>
        public AdresseReadRepository(MyDbContext mydbContext) : base(mydbContext)
        {
        }
    }
}
