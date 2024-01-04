using Digimash.Application.Abstractions.Messaging;

namespace Digimash.Application.Users.Commands.VerifyEmail
{
    public record VerifyEmailCommand(
        int Id,
        string Code) : ICommand;
}
