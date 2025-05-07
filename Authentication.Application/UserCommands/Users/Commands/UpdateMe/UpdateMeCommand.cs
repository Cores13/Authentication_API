using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Primitives;

namespace Authentication.Application.UserCommands.Users.Commands.UpdateMe
{
    public record UpdateMeCommand(
        int? Id,
        string Username,
        string Name,
        string? Password,
        string? PasswordConfirm) : ICommand;
}
