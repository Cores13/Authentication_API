namespace Authentication.Infrastructure.Services
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Authentication.Domain.Interfaces.Repository;
    using Authentication.Domain.Interfaces.Services;
    using Authentication.Infrastructure.Database;
    using Microsoft.EntityFrameworkCore;
    using PhoneNumbers;
    public class ValidationService : IValidationService
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserRepository _userRepository;

        public ValidationService(ApplicationDbContext context, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _context = context;
        }

        public async Task<bool> IsEmailUnique(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);

            var isUnique = user == null ? true : false;
            return isUnique;
        }

        public bool IsUserEmailUnique(string email, long? userId = null)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == email && x.Id != userId);

            return user is null ? true : false;
        }
    }
}
