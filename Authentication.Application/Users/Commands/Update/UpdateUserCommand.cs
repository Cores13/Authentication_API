using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.Users.Commands.Update
{
    public record UpdateUserCommand(
        int? Id,
        string? Name,
        string? Email,
        string? Password,
        int? Role) : ICommand;
}
