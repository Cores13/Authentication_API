using Digimash.Domain.Enums;

namespace Digimash.Domain.DTOs.Responses
{
    public class UserResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public UserRoleEnum Role { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public DateTime? EmailVerifiedAt { get; set; }
    }
}
