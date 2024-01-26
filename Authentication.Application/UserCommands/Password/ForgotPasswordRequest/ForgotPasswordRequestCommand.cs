using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.UserCommands.Password.ForgotPasswordRequest
{
    public record ForgotPasswordRequestCommand(string Email) : ICommand;
}
