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
    /// The get calendrier by praticien id request.
    /// </summary>
    public class GetCalendrierByPraticienIdRequest : IRequest<List<Calendrier>>
    {
        /// <summary>
        /// Gets or sets the praticien id.
        /// </summary>
        public int PraticienId { get; set; }
    }
}
