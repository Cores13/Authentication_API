using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Primitives;

namespace Authentication.Application.UserCommands.Users.Commands.Delete
{
    public record DeleteUserCommand(int? Id) : ICommand;
}
