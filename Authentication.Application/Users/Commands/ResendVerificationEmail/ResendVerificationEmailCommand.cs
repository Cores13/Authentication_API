using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.Users.Commands.ResendVerificationEmail
{
    public record ResendVerificationEmailCommand(int Id) : ICommand;
}
