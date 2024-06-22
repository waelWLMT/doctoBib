using BLL.Services.ReadServices;
using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.RoleQueries
{
    /// <summary>
    /// The get all role request handler.
    /// </summary>
    public class GetAllRoleRequestHandler : IRequestHandler<GetAllRoleRequest, List<Role>>
    {
        /// <summary>
        /// The read service.
        /// </summary>
        private readonly IRoleReadService _readService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllRoleRequestHandler"/> class.
        /// </summary>
        /// <param name="readService">The read service.</param>
        public GetAllRoleRequestHandler(IRoleReadService readService)
        {
            _readService = readService;
        }
        
        /// <summary>
        /// Handle and return a task of a list of roles.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns><![CDATA[Task<List<Role>>]]></returns>
        public async Task<List<Role>> Handle(GetAllRoleRequest request, CancellationToken cancellationToken)
        {
            return await _readService.GetAllAsync();
        }
    }
}
