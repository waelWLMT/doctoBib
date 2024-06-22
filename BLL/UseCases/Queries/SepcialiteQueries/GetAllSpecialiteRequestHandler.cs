using BLL.Services.ReadServices;
using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.SepcialiteQueries
{
    /// <summary>
    /// The get all specialite request handler.
    /// </summary>
    public class GetAllSpecialiteRequestHandler : IRequestHandler<GetAllSpecialiteRequest, List<Specialite>>
    {
        /// <summary>
        /// The read service.
        /// </summary>
        private readonly ISpecialiteReadService _readService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllSpecialiteRequestHandler"/> class.
        /// </summary>
        /// <param name="readService">The read service.</param>
        public GetAllSpecialiteRequestHandler(ISpecialiteReadService readService)
        {
            _readService = readService;
        }


        /// <summary>
        /// Handle and return a task of a list of specialites.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns><![CDATA[Task<List<Specialite>>]]></returns>
        public async Task<List<Specialite>> Handle(GetAllSpecialiteRequest request, CancellationToken cancellationToken)
        {
            return await _readService.GetAllAsync();
        }
    }
}
