using Authentication.Application.Abstractions.Messaging;
using Authentication.Application.Mappers;
using Authentication.Domain.Core.Errors;
using Authentication.Domain.Core.Primitives;
using Authentication.Domain.DTOs.Responses;
using Authentication.Domain.Interfaces.Repository;

namespace Authentication.Application.UserCommands.Users.Queries.GetAll
{
    internal sealed class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, ICollection<UserResponseDto?>>
    {
        private readonly IUserRepository _userRepository;

        public GetAllUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result<ICollection<UserResponseDto?>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken = default)
        {
            var users = await _userRepository.GetAll();

            if (users is null)
            {
                return Result.Failure<ICollection<UserResponseDto?>>(
                    DomainErrors.User.DoesNotExist);
            }

            return Result.Success(users.ToDto());
        }
    }
}
