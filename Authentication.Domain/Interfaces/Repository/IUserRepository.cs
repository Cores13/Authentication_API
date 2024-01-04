using Digimash.Domain.DTOs.Paging;
using Digimash.Domain.DTOs.Requests;
using Digimash.Domain.DTOs.Responses;
using Digimash.Domain.Entities;
using System.Linq.Expressions;

namespace Digimash.Domain.Interfaces.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<PagedResponse<UserResponseDto?>> GetAllPaged(PagedRequest<string> pagedQuery);

        Task<User?> GetByIdAsync(int id, CancellationToken cancellationToken);

        Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken);

        Task Update(User user, CancellationToken cancellationToken);
    }
}
