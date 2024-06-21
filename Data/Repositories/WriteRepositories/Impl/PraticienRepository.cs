﻿using Core.Models;
using Data.RepositoryPatterns.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.WriteRepositories.Impl
{
    /// <summary>
    /// The praticien repository.
    /// </summary>
    public class PraticienRepository : Repository<Praticien>, IPraticienRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PraticienRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The db context.</param>
        public PraticienRepository(MyDbContext dbContext) : base(dbContext)
        {
        }
    }
}
