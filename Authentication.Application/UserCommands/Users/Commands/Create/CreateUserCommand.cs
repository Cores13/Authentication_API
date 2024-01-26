using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.UserCommands.Users.Commands.Create
{
    public record CreateUserCommand(
        string Username,
        string Name,
        string Email,
        string PhoneNumber,
        string PhoneRegion,
        string Password,
        string PasswordConfirm,
        int Role,
        int Status,
        int? Id) : ICommand;
}
