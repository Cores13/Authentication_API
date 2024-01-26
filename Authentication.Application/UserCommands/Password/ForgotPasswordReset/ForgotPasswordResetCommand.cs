using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.UserCommands.Password.ForgotPasswordReset
{
    public record ForgotPasswordResetCommand(string Email, string Password, string Code) : ICommand;
}
