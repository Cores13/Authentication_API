using Digimash.Application.Abstractions.Messaging;
using Digimash.Domain.DTOs.Paging;
using Digimash.Domain.DTOs.Responses;

namespace Digimash.Application.Users.Queries.GetOne
{
    public record GetAllUsersQuery(PagedRequest<string> PagedQuery) : IQuery<PagedResponse<UserResponseDto?>>;
}
