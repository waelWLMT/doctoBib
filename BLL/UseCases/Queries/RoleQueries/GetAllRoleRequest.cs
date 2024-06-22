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
    /// The get all role request.
    /// </summary>
    public class GetAllRoleRequest : IRequest<List<Role>>
    {
    }
}
