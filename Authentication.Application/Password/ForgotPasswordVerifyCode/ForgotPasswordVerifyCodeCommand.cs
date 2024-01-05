using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.Password.ForgotPasswordVerifyCode
{
    public record ForgotPasswordVerifyCodeCommand(string Email, string Code) : ICommand;
}
