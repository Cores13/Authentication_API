using Digimash.Application.Abstractions.Messaging;

namespace Digimash.Application.Users.Commands.Delete
{
    public record DeleteUserCommand(int? Id) : ICommand;
}
