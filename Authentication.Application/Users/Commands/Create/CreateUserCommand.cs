using Digimash.Application.Abstractions.Messaging;

namespace Digimash.Application.Users.Commands.Create
{
    public record CreateUserCommand(
        string Name,
        string Email,
        string Password,
        int Role,
        int? Id) : ICommand;
}
