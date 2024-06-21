using BLL.Services.ReadServices;
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

        /// <summary>
        /// The commune service.
        /// </summary>
        private readonly ICommuneReadService _communeService;
        /// <summary>
        /// Initializes a new instance of the <see cref="CommuneController"/> class.
        /// </summary>
        /// <param name="communeService">The commune service.</param>
        public CommuneController(ICommuneReadService communeService)
        {
            _communeService = communeService;
        }
        /// <summary>
        /// Get commune by code postal.
        /// </summary>
        /// <param name="codePostal">The code postal.</param>
        /// <returns>An object</returns>
        [HttpGet("GetCommuneByCodePostal/{codePostal}")]
        public object GetCommuneByCodePostal(string codePostal)
        {
            return _communeService.GetCommuneByCodePostal(codePostal);
        }

        /// <summary>
        /// Get all commune list.
        /// </summary>
        /// <returns><![CDATA[Task<object>]]></returns>
        [HttpGet("GetAllCommuneList")]
        public async Task<object> GetAllCommuneList()
        {
            return await _communeService.GetAllCommune();
        }

        /// <summary>
        /// Get commune by departement.
        /// </summary>
        /// <param name="codeDepartement">The code departement.</param>
        /// <returns><![CDATA[Task<object>]]></returns>
        [HttpGet("GetCommuneByDepartement/{codeDepartement}")]
        public async Task<object> GetCommuneByDepartement(string codeDepartement)
        {
            return await _communeService.GetCommuneByCodeDepartement(codeDepartement);
        }

        /// <summary>
        /// Get commune by epci.
        /// </summary>
        /// <param name="epciCode">The epci code.</param>
        /// <returns><![CDATA[Task<object>]]></returns>
        [HttpGet("GetCommuneByEpci/{epciCode}")]
        public async Task<object> GetCommuneByEpci(string epciCode)
        {
            return await _communeService.GetCommuneByEpciCode(epciCode);
        }

    }
}
