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
    /// The get all menu request.
    /// </summary>
    public class GetAllMenuRequest : IRequest<List<Menu>>
    {

    }
}
