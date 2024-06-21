using Core.Models;
using Data.RepositoryPatterns;
using Data.RepositoryPatterns.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.ReadRepositories
{
    public interface IMenuReadRepository : IReadRepository<Menu>
    {
    }
}
