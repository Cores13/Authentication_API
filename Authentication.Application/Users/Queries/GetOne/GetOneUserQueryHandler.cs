using Digimash.Application.Abstractions.Messaging;
using Digimash.Application.Mappers;
using Digimash.Domain.Core.Errors;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.DTOs.Responses;
using Digimash.Domain.Interfaces.Repository;

namespace Digimash.Application.Users.Queries.GetOne
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
