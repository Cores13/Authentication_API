using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.UserCommands.Users.Commands.Logout
{
    public record LogoutCommand(int Id) : ICommand;
}
