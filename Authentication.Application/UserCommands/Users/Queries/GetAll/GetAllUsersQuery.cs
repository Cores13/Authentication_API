using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.DTOs.Responses;

namespace Authentication.Application.UserCommands.Users.Queries.GetAll
{
    public record GetAllUsersQuery() : IQuery<ICollection<UserResponseDto?>>;
}
