using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BlazorWasmRoleBasedIdentity.Server.Extensions
{
    public static class ApiAuthorizationOptionsExtensions
    {
        public static void AddRoleAndPermissionClaim(this ApiAuthorizationOptions options)
        {
            options.IdentityResources["openid"].UserClaims.Add("role");
            options.ApiResources.Single().UserClaims.Add("role");
            options.IdentityResources["openid"].UserClaims.Add("permission");
            options.ApiResources.Single().UserClaims.Add("permission");
        }
    }
}
