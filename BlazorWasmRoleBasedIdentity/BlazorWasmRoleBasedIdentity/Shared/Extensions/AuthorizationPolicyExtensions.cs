using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorWasmRoleBasedIdentity.Shared.Extensions
{
    public static class AuthorizationPolicyExtensions
    {
        public static void RequirePermission(this AuthorizationPolicyBuilder policy,string value)
        {
            policy.RequireClaim("permission", value);
        }
    }
}
