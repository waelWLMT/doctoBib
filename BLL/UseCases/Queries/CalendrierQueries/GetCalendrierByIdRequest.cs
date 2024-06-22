using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.CalendrierQueries
{
    /// <summary>
    /// The get calendrier by id request.
    /// </summary>
    public class GetCalendrierByIdRequest : IRequest<Calendrier>
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id{ get; set; }
    }
}
