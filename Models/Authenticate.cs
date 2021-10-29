using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationWebAPI.Models
{
    public class Authenticate
    {
        public string EmployeeId { get; set; }
        public string Password { get; set; }
    }
}
