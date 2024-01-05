using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.Users.Commands.Delete
{
    public record DeleteUserCommand(int? Id) : ICommand;
}
