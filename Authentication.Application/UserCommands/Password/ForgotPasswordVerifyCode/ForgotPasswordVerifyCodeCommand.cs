using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Primitives;

namespace Authentication.Application.UserCommands.Password.ForgotPasswordVerifyCode
{
    public record ForgotPasswordVerifyCodeCommand(string Email, string Code) : ICommand;
}
