using System.Security.Claims;

namespace Digimash.Domain.Interfaces.Services
{
    public interface IAuthService
    {
        string CreateRefreshToken();
        ClaimsPrincipal GetPrincipleFromExpiredToken(string token);
    }
}
