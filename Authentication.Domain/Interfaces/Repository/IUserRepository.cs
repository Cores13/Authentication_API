using Authentication.Domain.DTOs.Paging;
using Authentication.Domain.DTOs.Responses;
using Authentication.Domain.Entities;

namespace Authentication.Domain.Interfaces.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<PagedResponse<UserResponseDto?>> GetAllPaged(PagedRequest<string> pagedQuery);

        Task<User?> GetByRefreshTokenAsync(string refreshToken, CancellationToken cancellationToken = default);

        Task<User?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

        Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

        Task Update(User user, CancellationToken cancellationToken = default);

        bool IsEmailUnique(string email, int? id = null);

        bool IsPhoneNumberUnique(string phoneNumber, int? id = null);

        bool IsUsernameUnique(string username, int? id = null);
    }
}
