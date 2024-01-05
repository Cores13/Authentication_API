using Authentication.Domain.DTOs.Responses;
using Authentication.Domain.Entities;
using Authentication.Domain.Interfaces.Repository;
using Authentication.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Authentication.Application.Mappers;
using Authentication.Domain.DTOs.Paging;
using Newtonsoft.Json;
using Authentication.Domain.Enums;
using Authentication.Domain.Core.Extensions;

namespace Authentication.Infrastructure.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<PagedResponse<UserResponseDto?>> GetAllPaged(PagedRequest<string> pagedQuery)
        {
            var query = _context.Users
                .OrderByDescending(x => x.CreatedOn)
                .AsQueryable();

            if (pagedQuery.Filter != null)
            {
                var filters = JsonConvert.DeserializeObject<Dictionary<string, object>>(pagedQuery.Filter);

                if (filters.TryGetValue("search", out var nameFilter) && !string.IsNullOrWhiteSpace(nameFilter.ToString()))
                {
                    query = query.Where(x => x.Name.Contains(nameFilter.ToString()));
                }

                if (filters.TryGetValue("role", out var roleFilter) && roleFilter != null)
                {
                    var role = (UserRoleEnum)Enum.ToObject(typeof(UserRoleEnum), roleFilter);
                    query = query.Where(x => x.Role == role);
                }
            }

            if (!string.IsNullOrWhiteSpace(pagedQuery.OrderByKey))
            {
                query = query.OrderBy(pagedQuery.OrderByKey.ToString());
            }

            var totalResults = await query.CountAsync();

            query = query.Skip(pagedQuery.ItemsToSkip()).Take(pagedQuery.PageSize);

            var results = await query.ToListAsync();

            return new PagedResponse<UserResponseDto?>
            {
                Results = results.ToDto(),
                Page = pagedQuery.Page,
                PageSize = pagedQuery.PageSize,
                TotalResults = totalResults
            };
        }

        public async Task<User?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Users.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken)
        {
            return await _context.Users.SingleOrDefaultAsync(x => x.Email == email);
        }

        public async Task Update(User entity, CancellationToken cancellationToken)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == entity.Id);
            user.Name = string.IsNullOrEmpty(entity.Name) ? user.Name : entity.Name;
            user.Email = string.IsNullOrEmpty(entity.Email) ? user.Email : entity.Email;
            user.PasswordHash = entity.PasswordHash ?? user.PasswordHash;
            user.PasswordSalt = entity.PasswordSalt ?? user.PasswordSalt;
            user.Role = entity.Role is null ? user.Role : (UserRoleEnum)Enum.ToObject(typeof(UserRoleEnum), entity.Role);

            //_context.Users.Update(entity);
        }
    }
}
