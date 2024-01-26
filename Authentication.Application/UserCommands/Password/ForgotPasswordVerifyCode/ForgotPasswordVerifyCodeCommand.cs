using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.UserCommands.Password.ForgotPasswordVerifyCode
{
    public record ForgotPasswordVerifyCodeCommand(string Email, string Code) : ICommand;
}
