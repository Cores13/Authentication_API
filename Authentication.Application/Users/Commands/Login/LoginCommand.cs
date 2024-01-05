using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.DTOs.Responses;

namespace Authentication.Application.Users.Commands.Login
{
    public record LoginCommand(string Email, string Password) : ICommand<TokenResponseDto>;
}
