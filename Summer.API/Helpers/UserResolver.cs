using System.Security.Claims;

namespace Summer.API.Helpers;

public static class UserResolver
{
    public static int GetUserId(this HttpContext context)
    {
        if (context.User == null) return 0;
        return int.Parse(context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
    }
}