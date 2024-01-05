using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.Password.ForgotPasswordRequest
{
    public record ForgotPasswordRequestCommand(string Email) : ICommand;
}
