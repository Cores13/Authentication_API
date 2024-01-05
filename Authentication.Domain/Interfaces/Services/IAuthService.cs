using System.Security.Claims;

namespace Authentication.Domain.Interfaces.Services
{
    public interface IAuthService
    {
        string CreateRefreshToken();
        ClaimsPrincipal GetPrincipleFromExpiredToken(string token);
    }
}
