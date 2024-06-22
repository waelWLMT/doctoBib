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
    /// The get all specialite request.
    /// </summary>
    public class GetAllSpecialiteRequest : IRequest<List<Specialite>>
    {
    }
}
