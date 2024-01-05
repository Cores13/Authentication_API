using Authentication.Application.Abstractions.Messaging;

namespace Authentication.Application.Users.Commands.Logout
{
    public record LogoutCommand(int Id) : ICommand;
}
