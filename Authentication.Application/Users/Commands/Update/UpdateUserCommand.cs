using Digimash.Application.Abstractions.Messaging;

namespace Digimash.Application.Users.Commands.Update
{
    public record UpdateUserCommand(
        int? Id,
        string? Name,
        string? Email,
        string? Password,
        int? Role) : ICommand;
}
