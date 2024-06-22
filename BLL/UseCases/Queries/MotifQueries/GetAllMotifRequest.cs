using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.MotifQueries
{
    /// <summary>
    /// The get all motif request.
    /// </summary>
    public class GetAllMotifRequest : IRequest<List<Motif>>
    {
    }
}
