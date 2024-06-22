using BLL.Services.ReadServices;
using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.PraticienQueries
{
    /// <summary>
    /// The gel all praticien request handler.
    /// </summary>
    public class GelAllPraticienRequestHandler : IRequestHandler<GelAllPraticienRequest, List<Praticien>>
    {

        /// <summary>
        /// The read service.
        /// </summary>
        private readonly IPraticienReadService _readService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GelAllPraticienRequestHandler"/> class.
        /// </summary>
        /// <param name="readService">The read service.</param>
        public GelAllPraticienRequestHandler(IPraticienReadService readService)
        {
            _readService = readService;
        }
       
        /// <summary>
        /// Handle and return a task of a list of praticiens.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns><![CDATA[Task<List<Praticien>>]]></returns>
        public async Task<List<Praticien>> Handle(GelAllPraticienRequest request, CancellationToken cancellationToken)
        {
            return await _readService.GetAllAsync();
        }


    }
}
