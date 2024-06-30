
using BLL.Services.ReadServices.Impl;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Moq;
using Moq.Protected;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace doctoBib.Tests.BLL.Tests.Services
{
    /// <summary>
    /// The commune read service test.
    /// </summary>
    public class CommuneReadServiceTest
    {

        /// <summary>
        /// The config.
        /// </summary>
        private readonly Mock<IConfiguration> _config;
        
        /// <summary>
        /// The http client.
        /// </summary>
        private readonly Mock<HttpClient> _httpClient;
        
        /// <summary>
        /// The mock http message handler.
        /// </summary>
        private readonly Mock<HttpMessageHandler> _mockHttpMessageHandler;
        
        /// <summary>
        /// The base url.
        /// </summary>
        private const string _baseUrl = "https://geo.api.gouv.fr";

        /// <summary>
        /// Initializes a new instance of the <see cref="CommuneReadServiceTest"/> class.
        /// </summary>
        public CommuneReadServiceTest()
        {
            _config = new Mock<IConfiguration>();
            _httpClient = new Mock<HttpClient>();
            _mockHttpMessageHandler = new Mock<HttpMessageHandler>();
        }

        #region Test methods

        /// <summary>
        /// Get commune by code postal returns list commune.
        /// </summary>
        [Fact]
        public void GetCommuneByCodePostal_ReturnsListCommune()
        {

            // Arrange
            var codePostal = "75005";
            //var mockHttpMessageHandler = new Mock<HttpMessageHandler>();

            _mockHttpMessageHandler
                .Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage { StatusCode = HttpStatusCode.OK, Content = genrateStrContent() });

            var httpClient = new HttpClient(_mockHttpMessageHandler.Object);
            _config.Setup(x => x.GetSection("geoApiGouv").Value).Returns(_baseUrl);

            var service = new CommuneReadService(_config.Object, _httpClient.Object);

            // Act
            var result = service.GetCommuneByCodePostal(codePostal);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<string>(result.Result);

        }

        /// <summary>
        /// Get all commune returns list commune.
        /// </summary>
        [Fact]
        public void GetAllCommune_ReturnsListCommune()
        {



            // Arrange           
            _mockHttpMessageHandler
               .Protected()
               .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(new HttpResponseMessage { StatusCode = HttpStatusCode.OK, Content = genrateStrContent() });

            _config.Setup(x => x.GetSection(It.IsAny<string>()).Value).Returns(_baseUrl);

            var service = new CommuneReadService(_config.Object, _httpClient.Object);           

            // Act
            var result = service.GetAllCommune();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<string>(result.Result);

        }

        /// <summary>
        /// Get commune by departement code returns list commune by departement code.
        /// </summary>
        [Fact]
        public void GetCommuneByDepartementCode_ReturnsListCommuneByDepartementCode()
        {
            var codeDepartement = "75";
            // Arrange           
            _mockHttpMessageHandler
               .Protected()
               .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(new HttpResponseMessage { StatusCode = HttpStatusCode.OK, Content = genrateStrContent() });
            
            _config.Setup(x => x.GetSection(It.IsAny<string>()).Value).Returns(_baseUrl);


            var service = new CommuneReadService(_config.Object, _httpClient.Object);

            // Act
            var result = service.GetCommuneByCodeDepartement(codeDepartement).Result;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<string>(result);

        }

        /// <summary>
        /// Get commune by epci code returns list commune by epci code.
        /// </summary>
        [Fact]
        public void GetCommuneByEpciCode_ReturnsListCommuneByEpciCode()
        {
            var codeEpci = "247800584";
           
            // Arrange           
            _mockHttpMessageHandler
               .Protected()
               .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(new HttpResponseMessage { StatusCode = HttpStatusCode.OK, Content = genrateStrContent() });

            _config.Setup(x => x.GetSection(It.IsAny<string>()).Value).Returns(_baseUrl);

            var service = new CommuneReadService(_config.Object, _httpClient.Object);

            // Act
            var result = service.GetCommuneByEpciCode(codeEpci);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<string>(result.Result);

        }


        #endregion

        #region Methods

        /// <summary>
        /// Genrates str content.
        /// </summary>
        /// <returns>A StringContent</returns>
        private StringContent genrateStrContent()
        {
            var content = "[{\"nom\":\"Paris\",\"code\":\"75056\",\"codeDepartement\":\"75\",\"siren\":\"217500016\",\"codeEpci\":\"200054781\",\"codeRegion\":\"11\",\"codesPostaux\":[\"75001\",\"75002\",\"75003\",\"75004\",\"75005\",\"75006\",\"75007\",\"75008\",\"75009\",\"75010\",\"75011\",\"75012\",\"75013\",\"75014\",\"75015\",\"75016\",\"75017\",\"75018\",\"75019\",\"75020\",\"75116\"],\"population\":2133111}]";
            return new StringContent(content);  
        }

        #endregion

    }
}
