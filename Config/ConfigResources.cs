using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace IdentityServer4Login.Config
{
    public static class ConfigResources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>()
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
                new IdentityResource
                {
                    Name="role",
                    UserClaims= new List<string>
                    {
                        "role"
                    }
                }
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource
                {
                    Name="customAPI",
                    DisplayName="Custom Apı",
                    Description="Customized Api",
                    UserClaims=new List<string>{"role"},
                    ApiSecrets=new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    },
                    Scopes = new List<Scope>
                    {
                        new Scope("customAPI.read"),
                        new Scope("customAPI.write"),
                        new Scope("customAPI.delete"),
                        new Scope("customAPI.update"),
                    }
                 
        }
    };
}
    }
}
