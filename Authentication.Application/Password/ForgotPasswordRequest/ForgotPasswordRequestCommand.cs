using Digimash.Application.Abstractions.Messaging;

namespace Digimash.Application.Password.ForgotPasswordRequest
{
    public record ForgotPasswordRequestCommand(string Email) : ICommand;
}
