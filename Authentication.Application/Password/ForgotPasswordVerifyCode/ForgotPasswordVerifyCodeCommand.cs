using Digimash.Application.Abstractions.Messaging;

namespace Digimash.Application.Password.ForgotPasswordVerifyCode
{
    public record ForgotPasswordVerifyCodeCommand(string Email, string Code) : ICommand;
}
