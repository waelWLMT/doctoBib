using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{

    /// <summary>
    /// The authentication controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        /// <summary>
        /// The logger.
        /// </summary>
        private readonly ILogger<AuthenticationController> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationController"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public AuthenticationController(ILogger<AuthenticationController> logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// Authenticates the user.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The password.</param>
        /// <returns>An User</returns>
        [HttpGet(Name ="AuthenticateUser")]
        public User AuthenticateUser(string userName, string password)
        {
            return new User();
        }

    }
}
