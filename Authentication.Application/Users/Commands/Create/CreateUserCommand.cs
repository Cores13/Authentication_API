using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.Users.Commands.Create
{
    public record CreateUserCommand(
        string Name,
        string Email,
        string Password,
        int Role,
        int? Id) : ICommand;
}
