using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.UserCommands.Users.Commands.ResendVerificationEmail
{
    public record ResendVerificationEmailCommand(int Id) : ICommand;
}
