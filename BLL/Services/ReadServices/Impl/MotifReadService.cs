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
    /// <summary>
    /// The motif read service.
    /// </summary>
    public class MotifReadService : ReadServicePattern<Motif>, IMotifReadService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MotifReadService"/> class.
        /// </summary>
        /// <param name="motifReadRepository">The motif read repository.</param>
        public MotifReadService(IMotifReadRepository motifReadRepository) : base(motifReadRepository)
        {
        }
    }
}
