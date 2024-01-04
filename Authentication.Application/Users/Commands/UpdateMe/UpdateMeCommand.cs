using Digimash.Application.Abstractions.Messaging;

namespace Digimash.Application.Users.Commands.UpdateMe
{
    public record UpdateMeCommand(
        int? Id,
        string Name,
        string Email,
        string? Password) : ICommand;
}
