using BLL.Services.ReadServices;
using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.MenuQueries
{
    /// <summary>
    /// The get all menu request handler.
    /// </summary>
    public class GetAllMenuRequestHandler : IRequestHandler<GetAllMenuRequest, List<Menu>>
    {
        /// <summary>
        /// The read service.
        /// </summary>
        private readonly IMenuReadService _readService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllMenuRequestHandler"/> class.
        /// </summary>
        /// <param name="readService">The read service.</param>
        public GetAllMenuRequestHandler(IMenuReadService readService)
        {
            _readService = readService;
        }

        /// <summary>
        /// Handle and return a task of a list of menus.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns><![CDATA[Task<List<Menu>>]]></returns>
        public async Task<List<Menu>> Handle(GetAllMenuRequest request, CancellationToken cancellationToken)
        {
            return await _readService.GetAllAsync();
        }
    }
}
