using BLL.Services.ReadServices;
using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.PatientQueries
{
    /// <summary>
    /// The get all patien request handler.
    /// </summary>
    public class GetAllPatienRequestHandler : IRequestHandler<GetAllPatientRequest, List<Patient>>
    {
        /// <summary>
        /// The read service.
        /// </summary>
        private readonly IPatientReadService _readService;
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllPatienRequestHandler"/> class.
        /// </summary>
        /// <param name="readService">The read service.</param>
        public GetAllPatienRequestHandler(IPatientReadService readService)
        {
            _readService = readService;
        }
        /// <summary>
        /// Handle and return a task of a list of patients.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns><![CDATA[Task<List<Patient>>]]></returns>
        public async Task<List<Patient>> Handle(GetAllPatientRequest request, CancellationToken cancellationToken)
        {
            return await _readService.GetAllAsync();
        }
    
    }
}
