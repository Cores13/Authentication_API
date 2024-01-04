using Digimash.Application.Abstractions.Messaging;
using Digimash.Domain.DTOs.Responses;

namespace Digimash.Application.Users.Commands.Login
{
    public record LoginCommand(string Email, string Password) : ICommand<TokenResponseDto>;
}
