using BLL.Services.ReadServices;
using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.RendezVousQueries
{
    /// <summary>
    /// The get all rdv praticien by dates request handler.
    /// </summary>
    public class GetAllRdvPraticienByDatesRequestHandler : IRequestHandler<GetAllRdvPraticienByDatesRequest, List<RendezVous>>
    {
        /// <summary>
        /// The read service.
        /// </summary>
        private readonly IRendezVousReadService _readService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllRdvPraticienByDatesRequestHandler"/> class.
        /// </summary>
        /// <param name="readService">The read service.</param>
        public GetAllRdvPraticienByDatesRequestHandler(IRendezVousReadService readService)
        {
            _readService = readService;
        }

        /// <summary>
        /// Handle and return a task of a list of rendezvous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns><![CDATA[Task<List<RendezVous>>]]></returns>
        public async Task<List<RendezVous>> Handle(GetAllRdvPraticienByDatesRequest request, CancellationToken cancellationToken)
        {
            var rdvs = await _readService.GetAllAsync(x => x.PraticienId == request.IdPraticien && x.Date >= request.DateDebut && x.Date <= request.DateFin, x => x.Praticien, x => x.Patient, x => x.Motif);

            return rdvs;
        }
    }
}
