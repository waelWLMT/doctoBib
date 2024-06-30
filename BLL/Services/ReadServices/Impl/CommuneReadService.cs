using Core.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ReadServices.Impl
{
    /// <summary>
    /// The commune read service.
    /// </summary>
    public class CommuneReadService : ICommuneReadService
    {

        #region attributes
        /// <summary>
        /// The configuration.
        /// </summary>
        private readonly IConfiguration _configuration;
        /// <summary>
        /// The http client.
        /// </summary>
        private readonly HttpClient _httpClient;
        #endregion

        #region constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CommuneReadService"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="httpClient">The http client.</param>
        public CommuneReadService(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;

            ConfigureMyHttpClient();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Configure my http client.
        /// </summary>
        private void ConfigureMyHttpClient()
        {

            var baseUrl = _configuration.GetSection("geoApiGouv")?.Value?.ToString();

            if(_httpClient.BaseAddress == null) 
                _httpClient.BaseAddress =  new Uri(baseUrl);
            
             
            _httpClient.Timeout = new TimeSpan(0, 0, 30);
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml", 0.9));


        }

        /// <summary>
        /// Get commune by code postal.
        /// </summary>
        /// <param name="codePostal">The code postal.</param>
        /// <returns><![CDATA[Task<object?>]]></returns>
        public async Task<object?> GetCommuneByCodePostal(string codePostal)
        {
            var apiUrl = "communes?codePostal=" + codePostal;


            var response = _httpClient.GetAsync(apiUrl.Trim()).Result;
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();


        }

        /// <summary>
        /// Get all commune.
        /// </summary>
        /// <returns><![CDATA[Task<object>]]></returns>
        public async Task<object> GetAllCommune()
        {

            var apiUrl = "communes";

            var response = _httpClient.GetAsync(apiUrl.Trim()).Result;

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();

        }

        /// <summary>
        /// Get commune by code departement.
        /// </summary>
        /// <param name="codeDepartement">The code departement.</param>
        /// <returns><![CDATA[Task<object>]]></returns>
        public async Task<object> GetCommuneByCodeDepartement(string codeDepartement)
        {
            var apiUrl = new StringBuilder("/departements/");
            apiUrl.Append(codeDepartement);
            apiUrl.Append("/communes");

            var response = _httpClient.GetAsync(apiUrl.ToString().Trim()).Result;
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Get commune by epci code.
        /// </summary>
        /// <param name="epciCode">The epci code.</param>
        /// <returns><![CDATA[Task<object>]]></returns>
        public async Task<object> GetCommuneByEpciCode(string epciCode)
        {
            
            var apiUrl = new StringBuilder("/epcis/");
            apiUrl.Append(epciCode);
            apiUrl.Append("/communes");

            var response =  _httpClient.GetAsync(apiUrl.ToString().Trim()).Result;
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
           
            return result;

        }

        #endregion

    }
}
