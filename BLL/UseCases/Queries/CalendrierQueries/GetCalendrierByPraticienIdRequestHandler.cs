using BLL.Services.ReadServices;
using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.CalendrierQueries
{
    /// <summary>
    /// The get calendrier by praticien id request handler.
    /// </summary>
    public class GetCalendrierByPraticienIdRequestHandler : IRequestHandler<GetCalendrierByPraticienIdRequest, List<Calendrier>>
    {
        /// <summary>
        /// The read service.
        /// </summary>
        private readonly ICalendrierReadService _readService;
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCalendrierByPraticienIdRequestHandler"/> class.
        /// </summary>
        /// <param name="readService">The read service.</param>
        public GetCalendrierByPraticienIdRequestHandler(ICalendrierReadService readService)
        {
            _readService = readService;
        }
        /// <summary>
        /// Handle and return a task of a list of calendriers.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns><![CDATA[Task<List<Calendrier>>]]></returns>
        public async Task<List<Calendrier>> Handle(GetCalendrierByPraticienIdRequest request, CancellationToken cancellationToken)
        {
            return await _readService.GetAllAsync(x=> x.PraticienId == request.PraticienId);
        }
    }
}
