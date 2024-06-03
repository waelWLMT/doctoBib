using BLL.Services.ReadServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Usefull.Impl
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserReadService _userReadService;

        public AuthenticationService(IUserReadService userReadService)
        {
            _userReadService = userReadService;
        }

        public object Authenticate(string username, string password)
        {
            var user = _userReadService.GetAll(x=> x.Login == username, y=> y.Role).FirstOrDefault();
            if (user == null)
            {
                return null;
            }
            return user;
            // to be continued
           
        }
    }
}
