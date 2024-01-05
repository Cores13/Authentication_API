using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.DTOs.Paging;
using Authentication.Domain.DTOs.Responses;

namespace Authentication.Application.Users.Queries.GetOne
{
    public record GetAllUsersQuery(PagedRequest<string> PagedQuery) : IQuery<PagedResponse<UserResponseDto?>>;
}
