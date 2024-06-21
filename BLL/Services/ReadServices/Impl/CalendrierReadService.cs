using BLL.Pattern.Impl;
using Core.Models;
using Data;
using Data.Repositories.ReadRepositories;
using Data.RepositoryPatterns;
using Data.RepositoryPatterns.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ReadServices.Impl
{
    /// <summary>
    /// The calendrier read service.
    /// </summary>
    public class CalendrierReadService : ReadServicePattern<Calendrier>, ICalendrierReadService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendrierReadService"/> class.
        /// </summary>
        /// <param name="calendrierReadRepository">The calendrier read repository.</param>
        public CalendrierReadService(ICalendrierReadRepository calendrierReadRepository) : base(calendrierReadRepository)
        {
        }
    }
}
