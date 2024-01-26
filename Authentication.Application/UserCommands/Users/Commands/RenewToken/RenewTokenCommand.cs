using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.DTOs.Responses;

namespace Authentication.Application.UserCommands.Users.Commands.RenewToken
{
    public record RenewTokenCommand(string RefreshToken) : ICommand<TokenResponseDto>;
}
