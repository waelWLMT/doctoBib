using BLL.Pattern.Impl;
using Core.Models;
using Data.Repositories.ReadRepositories;
using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ReadServices.Impl
{
    public class RendezVousReadService : ReadServicePattern<RendezVous>, IRendezVousReadService
    {
        public RendezVousReadService(IRendezVousReadRepository readRepository) : base(readRepository)
        {
        }
    }
}
