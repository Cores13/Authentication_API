using Digimash.Application.Abstractions.Messaging;
using Digimash.Domain.Core.Errors;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.DTOs.Paging;
using Digimash.Domain.DTOs.Responses;
using Digimash.Domain.Interfaces.Repository;

namespace Digimash.Application.Users.Queries.GetOne
{
    internal sealed class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, PagedResponse<UserResponseDto?>>
    {
        private readonly IUserRepository _userRepository;

        public GetAllUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result<PagedResponse<UserResponseDto?>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllPaged(request.PagedQuery);

            if (users is null)
            {
                return Result.Failure<PagedResponse<UserResponseDto?>>(
                    DomainErrors.User.DoesNotExist);
            }

            return Result.Success(users);
        }
    }
}
