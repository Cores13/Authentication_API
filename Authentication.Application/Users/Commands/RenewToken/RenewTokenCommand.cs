using Digimash.Application.Abstractions.Messaging;
using Digimash.Domain.DTOs.Responses;

namespace Digimash.Application.Users.Commands.RenewToken
{
    public record RenewTokenCommand(string AccessToken, string RefreshToken) : ICommand<TokenResponseDto>;
}
