using AuthorizationWebAPI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationWebAPI.Services
{
    public interface IAuthService
    {
        public string GenerateJSONWebToken(Authenticate userInfo, IConfiguration _config);
        public dynamic AuthenticateUser(Authenticate login);
    }
}
