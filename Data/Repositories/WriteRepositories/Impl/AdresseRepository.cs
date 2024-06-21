using Core.Models;
using Data.RepositoryPatterns.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.WriteRepositories.Impl
{
    /// <summary>
    /// The adresse repository.
    /// </summary>
    public class AdresseRepository : Repository<Adresse>, IAdresseRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdresseRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The db context.</param>
        public AdresseRepository(MyDbContext dbContext) : base(dbContext)
        {
        }
    }
}
