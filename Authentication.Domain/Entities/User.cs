using Authentication.Domain.Enums;
using Authentication.Domain.Primitives;

namespace Authentication.Domain.Entities
{
    public sealed class User : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public DateTime? EmailVerifiedAt { get; set; }

        public string? RefreshToken { get; set; }

        public DateTime? RefreshTokenExpiryTime { get; set; }

        public string? ResetPasswordToken { get; set; }

        public DateTime? ResetPasswordExpiry { get; set; }

        public string? EmailVerificationToken { get; set; }

        public DateTime? EmailVerificationExpiry { get; set; }

        public UserRoleEnum? Role { get; set; }

    }
}