using BLL.Services.ReadServices;
using BLL.UseCases.Queries.CommuneQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.ObjectiveC;

namespace WebApi.Controllers
{
    /// <summary>
    /// The commune controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CommuneController : ControllerBase
    {

      
        private readonly IMediator _mediator;
       
        public CommuneController(IMediator mediator )
        {
            _mediator = mediator;
        }
       
        [HttpGet("GetCommuneByCodePostal/{codePostal}")]
        public async Task<object> GetCommuneByCodePostal(string codePostal)
        {

            var request = new GetCommuneByCodePostalRequest() {  CodePostal = codePostal };
            var result = await _mediator.Send(request);

            return result;
        }

       
        [HttpGet("GetAllCommuneList")]
        public async Task<object> GetAllCommuneList()
        {
            var request = new GetAllCommuneRequest() ;
            var result = await _mediator.Send(request);

            return result;
        }

        
        [HttpGet("GetCommuneByDepartement/{codeDepartement}")]
        public async Task<object> GetCommuneByDepartement(string codeDepartement)
        {
            var request = new GetCommuneByDepartementRequest() { CodeDepartement = codeDepartement };
            var result = await _mediator.Send(request);

            return result;
        }

       
        [HttpGet("GetCommuneByEpci/{epciCode}")]
        public async Task<object> GetCommuneByEpci(string epciCode)
        {
            var request = new GetCommuneByEpciCodeRequest() { EpciCode = epciCode };
            var result = await _mediator.Send(request);

            return result;
        }

    }
}
