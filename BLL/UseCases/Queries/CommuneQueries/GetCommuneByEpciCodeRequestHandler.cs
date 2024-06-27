using BLL.Services.ReadServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.CommuneQueries
{
    /// <summary>
    /// The get commune by epci code request handler.
    /// </summary>
    public class GetCommuneByEpciCodeRequestHandler : IRequestHandler<GetCommuneByEpciCodeRequest, object>
    {
        /// <summary>
        /// The read service.
        /// </summary>
        private readonly ICommuneReadService _readService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCommuneByEpciCodeRequestHandler"/> class.
        /// </summary>
        /// <param name="readService">The read service.</param>
        public GetCommuneByEpciCodeRequestHandler(ICommuneReadService readService)
        {
            _readService = readService;
        }
        /// <summary>
        /// Handle and return a task of type object.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns><![CDATA[Task<object>]]></returns>
        public async Task<object> Handle(GetCommuneByEpciCodeRequest request, CancellationToken cancellationToken)
        {
            return await _readService.GetCommuneByEpciCode(request.EpciCode);
        }
    }
}
