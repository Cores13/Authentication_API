using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Primitives;

namespace Authentication.Application.UserCommands.Users.Commands.Update
{
    public record UpdateUserCommand(
        int? Id,
        string Username,
        string Name,
        string Email,
        string PhoneNumber,
        string PhoneRegion,
        string? Password,
        string? PasswordConfirm,
        int? Role,
        int? Status) : ICommand;
}
