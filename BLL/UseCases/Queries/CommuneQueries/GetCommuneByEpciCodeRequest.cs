using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.CommuneQueries
{
    /// <summary>
    /// The get commune by epci code request.
    /// </summary>
    public class GetCommuneByEpciCodeRequest : IRequest<object>
    {
        /// <summary>
        /// Gets or sets the epci code.
        /// </summary>
        public string EpciCode { get; set; }
    }
}
