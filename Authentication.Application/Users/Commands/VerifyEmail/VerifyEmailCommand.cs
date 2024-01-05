using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.Users.Commands.VerifyEmail
{
    public record VerifyEmailCommand(
        int Id,
        string Code) : ICommand;
}
