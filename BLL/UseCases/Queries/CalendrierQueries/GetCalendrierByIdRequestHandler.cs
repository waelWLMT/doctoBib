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
    /// The get calendrier by id request handler.
    /// </summary>
    public class GetCalendrierByIdRequestHandler : IRequestHandler<GetCalendrierByIdRequest, Calendrier>
    {
        /// <summary>
        /// The read service.
        /// </summary>
        private readonly ICalendrierReadService _readService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCalendrierByIdRequestHandler"/> class.
        /// </summary>
        /// <param name="readService">The read service.</param>
        public GetCalendrierByIdRequestHandler(ICalendrierReadService readService)
        {
            _readService = readService;
        }

        /// <summary>
        /// Handle and return a task of type calendrier.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns><![CDATA[Task<Calendrier>]]></returns>
        public async Task<Calendrier> Handle(GetCalendrierByIdRequest request, CancellationToken cancellationToken)
        {
            var calendrier = await _readService.GetByIdAsync(request.Id);
            return calendrier;
        }

    }
}
