namespace Digimash.Application.Users.Commands.RenewToken
{
    public record RenewTokenRequest(string accessToken, string refreshToken);
}
