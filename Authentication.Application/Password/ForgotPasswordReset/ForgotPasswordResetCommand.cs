using Digimash.Application.Abstractions.Messaging;

namespace Digimash.Application.Password.ForgotPasswordReset
{
    public record ForgotPasswordResetCommand(string Email, string Password, string Code) : ICommand;
}
