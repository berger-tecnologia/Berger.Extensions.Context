using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Berger.Extensions.Context
{
    public static class ClaimHelper
    {
        public static string GetClaims(this HttpContext context, string claim)
        {
            return GetClaims(context.User, claim);
        }
        public static string GetClaims(this AuthorizationHandlerContext context, string claim)
        {
            return GetClaims(context.User, claim);
        }
        public static string GetClaims(this ClaimsPrincipal claimPrincipal, string claim)
        {
            return claimPrincipal.FindFirstValue(claim);
        }
    }
}