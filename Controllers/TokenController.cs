using AuthorizationWebAPI.Models;
using AuthorizationWebAPI.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthorizationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class TokenController : ControllerBase
    {
        private static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(TokenController));
        private IConfiguration config;
        private readonly IAuthService ap;
        public TokenController(IConfiguration config, IAuthService ap)
        {
            this.config = config;
            this.ap = ap;
        }

        [HttpPost]
        public IActionResult Login([FromBody] Authenticate login)
        {
            _log4net.Info(" Http Post request");
            if (login == null)
            {
                return BadRequest();
            }
            try
            {
                IActionResult response = Unauthorized();
                Authenticate user = ap.AuthenticateUser(login);

                if (user != null)
                {
                    var tokenString = ap.GenerateJSONWebToken(user, config);
                    var token = new Token() { AuditToken = tokenString };
                    response = Ok(token);
                }

                return response;
            }
            catch (Exception e)
            {
                _log4net.Error("Exception Occured " + e.Message);
                return StatusCode(500);
            }

        }
    }
}
