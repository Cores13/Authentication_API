using Digimash.Application.Abstractions.Messaging;
using Digimash.Domain.DTOs.Responses;

namespace Digimash.Application.Users.Queries.GetOne
{
    public record GetOneUserQuery(int Id) : IQuery<UserResponseDto>;
}
