namespace Authentication.Application.Users.Commands.RenewToken
{
    public record RenewTokenRequest(string accessToken, string refreshToken);
}
