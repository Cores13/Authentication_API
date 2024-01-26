using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.UserCommands.Users.Commands.VerifyEmail
{
    public record VerifyEmailCommand(
        int Id,
        string Code) : ICommand;
}
