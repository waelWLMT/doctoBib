using BLL.Services.ReadServices;
using BLL.Services.WriteServices;
using Core.Dtos;
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
    /// The get current week rdvs request handler.
    /// </summary>
    public class GetCurrentWeekRdvsRequestHandler : IRequestHandler<GetCurrentWeekRdvsRequest, List<RendezVous>>
    {
        /// <summary>
        /// The read service.
        /// </summary>
        private IRendezVousReadService _readService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCurrentWeekRdvsRequestHandler"/> class.
        /// </summary>
        /// <param name="readService">The read service.</param>
        public GetCurrentWeekRdvsRequestHandler(IRendezVousReadService readService)
        {
            _readService = readService;
        }
        /// <summary>
        /// Handle and return a task of a list of rendezvous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns><![CDATA[Task<List<RendezVous>>]]></returns>
        public async Task<List<RendezVous>> Handle(GetCurrentWeekRdvsRequest request, CancellationToken cancellationToken)
        {
            var dateDebut = DateTime.Now;
            var dateFin = dateDebut.AddDays(7);

            var rdvs = await _readService.GetAllAsync(x=> x.PraticienId == request.IdPraticien && x.Date >= dateDebut && x.Date <= dateFin, x => x.Patient, x => x.Praticien, x => x.Motif);

            return rdvs;
        }
    }
}
