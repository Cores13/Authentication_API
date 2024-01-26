using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.UserCommands.Users.Commands.Delete
{
    public record DeleteUserCommand(int? Id) : ICommand;
}
