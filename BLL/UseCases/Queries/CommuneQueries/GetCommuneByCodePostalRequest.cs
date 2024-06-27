using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.CommuneQueries
{
    /// <summary>
    /// The get commune by code postal request.
    /// </summary>
    public class GetCommuneByCodePostalRequest : IRequest<object>
    {
        /// <summary>
        /// Gets or sets the code postal.
        /// </summary>
        public string CodePostal { get; set; }
    }
}
