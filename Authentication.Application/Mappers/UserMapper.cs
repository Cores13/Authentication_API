using PhoneNumbers;
using Authentication.Domain.DTOs.Requests;
using Authentication.Domain.DTOs.Responses;
using Authentication.Domain.Enums;
using Authentication.Domain.Entities;

namespace Authentication.Application.Mappers
{
    public static class UserMapper 
    {
        public static User ToModel(this UserRequestDto user)
        {
            return new User
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                //EmailVerifiedAt = null,
                //RefreshToken = null,
                //RefreshTokenExpiryTime = null,
                //ResetPasswordToken = null,
                //ResetPasswordExpiry = null,
                Role = user.Role is null ? null : (UserRoleEnum)Enum.ToObject(typeof(UserRoleEnum), user.Role)
            };
        }

        public static UserResponseDto ToDto(this User user)
        {
            return new UserResponseDto
            {
                Id = (int)user.Id,
                Name = user.Name,
                Email = user.Email,
                Role = (UserRoleEnum)user.Role,
                CreatedOn = user.CreatedOn,
                EmailVerifiedAt = user.EmailVerifiedAt,
            };
        }

        public static ICollection<User> ToModel(this IEnumerable<UserRequestDto> users) => users.Select(x => x.ToModel()).ToList();

        public static ICollection<UserResponseDto> ToDto(this IEnumerable<User> users) => users.Select(x => x.ToDto()).ToList();
    }
}
