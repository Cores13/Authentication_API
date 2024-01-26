using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.DTOs.Responses;

namespace Authentication.Application.UserCommands.Users.Queries.GetOne
{
    public record GetOneUserQuery(int Id) : IQuery<UserResponseDto>;
}
