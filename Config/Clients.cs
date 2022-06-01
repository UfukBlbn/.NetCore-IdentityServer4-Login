using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer4Login.Config
{
    public static class Clients
    {
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId="oauthClientId",
                    ClientName="First Client",
                    AllowedGrantTypes=GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret>{new Secret("secret".Sha256())},
                    AllowedScopes = new List<string>{"customAPI.read"}
                }
            };
        }
    }
}
