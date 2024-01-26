using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.DTOs.Paging;
using Authentication.Domain.DTOs.Responses;

namespace Authentication.Application.UserCommands.Users.Queries.GetAllPaginated
{
    public record GetAllUsersPaginatedQuery(PagedRequest<string> PagedQuery) : IQuery<PagedResponse<UserResponseDto?>>;
}
