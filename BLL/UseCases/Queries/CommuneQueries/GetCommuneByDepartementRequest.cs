using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.CommuneQueries
{
    /// <summary>
    /// The get commune by departement request.
    /// </summary>
    public class GetCommuneByDepartementRequest : IRequest<object>
    {
        /// <summary>
        /// Gets or sets the code departement.
        /// </summary>
        public string CodeDepartement { get; set; }
    }
}
