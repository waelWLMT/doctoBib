using Core.Models;
using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.ReadRepositories
{
    public interface IRoleReadRepository : IReadRepository<Role>
    {
    }
}
