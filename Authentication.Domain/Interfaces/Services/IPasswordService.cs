using Digimash.Domain.Entities;

namespace Digimash.Domain.Interfaces.Services
{
    public interface IPasswordService
    {
        void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
        bool VerifyPassword(User user, string password);
        string CheckPasswordStrength(string password);
    }
}
