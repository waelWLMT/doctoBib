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
    public class CalendrierService : ServicePattern<Calendrier>, ICalendrierService
    {
        public CalendrierService(ICalendrierRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
