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
    /// The get commune by departement request handler.
    /// </summary>
    public class GetCommuneByDepartementRequestHandler : IRequestHandler<GetCommuneByDepartementRequest, object>
    {
        /// <summary>
        /// The read service.
        /// </summary>
        private readonly ICommuneReadService _readService;
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCommuneByDepartementRequestHandler"/> class.
        /// </summary>
        /// <param name="readService">The read service.</param>
        public GetCommuneByDepartementRequestHandler(ICommuneReadService readService)
        {
            _readService = readService;
        }
        /// <summary>
        /// Handle and return a task of type object.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns><![CDATA[Task<object>]]></returns>
        public async Task<object> Handle(GetCommuneByDepartementRequest request, CancellationToken cancellationToken)
        {
            return await _readService.GetCommuneByCodeDepartement(request.CodeDepartement);
        }
    }
}
