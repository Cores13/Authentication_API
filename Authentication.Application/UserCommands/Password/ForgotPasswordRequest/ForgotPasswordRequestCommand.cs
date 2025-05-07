using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Primitives;

namespace Authentication.Application.UserCommands.Password.ForgotPasswordRequest
{
    public record ForgotPasswordRequestCommand(string Email) : ICommand;
}
