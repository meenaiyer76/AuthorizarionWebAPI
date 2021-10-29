using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationWebAPI.Repository
{
    public interface ICredentialRepo
    {
        public Dictionary<string, string> GetCredentials();
    }
}
