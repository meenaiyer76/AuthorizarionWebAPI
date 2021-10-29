using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationWebAPI.Repository
{
    public class CredentialRepo:ICredentialRepo
    {
        private Dictionary<string, string> ValidUsersDictionary = new Dictionary<string, string>()
        {
               {"101","12345"},
               {"102","12345"},
               {"103","12345"},
               {"104","12345"},
               {"105","12345"}
        };
        public Dictionary<string, string> GetCredentials()
        {
            return ValidUsersDictionary;
        }
    }
}
