using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.Password.ForgotPasswordReset
{
    public record ForgotPasswordResetCommand(string Email, string Password, string Code) : ICommand;
}
