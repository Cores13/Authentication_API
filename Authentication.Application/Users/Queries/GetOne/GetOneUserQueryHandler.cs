using Authentication.Application.Abstractions.Messaging;
using Authentication.Application.Mappers;
using Authentication.Domain.Core.Errors;
using Authentication.Domain.Core.Primitives;
using Authentication.Domain.DTOs.Responses;
using Authentication.Domain.Interfaces.Repository;

namespace Authentication.Application.Users.Queries.GetOne
{
    internal sealed class GetOneUserQueryHandler : IQueryHandler<GetOneUserQuery, UserResponseDto>
    {
        private readonly IUserRepository _userRepository;

        public GetOneUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result<UserResponseDto>> Handle(GetOneUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id, cancellationToken);

            if (user is null)
            {
                return Result.Failure<UserResponseDto>(
                    DomainErrors.User.DoesNotExist);
            }

            var userDto = user.ToDto();

            return Result.Success(userDto);
        }
    }
}
