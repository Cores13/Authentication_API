using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.Users.Commands.UpdateMe
{
    public record UpdateMeCommand(
        int? Id,
        string Name,
        string Email,
        string? Password) : ICommand;
}
