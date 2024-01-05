using Authentication.Domain.DTOs.Paging;
using Authentication.Domain.DTOs.Requests;
using Authentication.Domain.DTOs.Responses;
using Authentication.Domain.Entities;
using System.Linq.Expressions;

namespace Authentication.Domain.Interfaces.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<PagedResponse<UserResponseDto?>> GetAllPaged(PagedRequest<string> pagedQuery);

        Task<User?> GetByIdAsync(int id, CancellationToken cancellationToken);

        Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken);

        Task Update(User user, CancellationToken cancellationToken);
    }
}
