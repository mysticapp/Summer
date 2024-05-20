using System.Security.Claims;
using Summer.Shared.Constants;

namespace Summer.API.Helpers;

public static class UserResolver
{
    public static int GetUserId(this HttpContext context)
    {
        if (context.User == null) return 0;
        return int.Parse(context.User.FindFirst(CustomClaims.Id)?.Value);
    }
}