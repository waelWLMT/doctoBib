using BLL.Pattern.Impl;
using Core.Models;
using Data.Repositories.WriteRepositories;
using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.WriteServices.Impl
{
    public class AdresseService : ServicePattern<Adresse>, IAdresseService
    {
        public AdresseService(IAdresseRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
