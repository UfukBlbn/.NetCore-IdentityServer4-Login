using IdentityModel;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer4Login.Config
{
    public static class Users
    {
        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId="subject-id",
                    Username="user",
                    Password="password",
                    Claims= new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Email,"user@user.com"),
                        new Claim(JwtClaimTypes.Role,"admin")
                    }
                }    

            };
        }
    }
}
