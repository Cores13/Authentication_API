using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.DTOs.Responses;

namespace Authentication.Application.Users.Commands.RenewToken
{
    public record RenewTokenCommand(string AccessToken, string RefreshToken) : ICommand<TokenResponseDto>;
}
