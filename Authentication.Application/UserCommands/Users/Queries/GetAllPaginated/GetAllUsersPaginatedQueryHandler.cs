using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Errors;
using Authentication.Domain.Core.Primitives;
using Authentication.Domain.DTOs.Paging;
using Authentication.Domain.DTOs.Responses;
using Authentication.Domain.Interfaces.Repository;

namespace Authentication.Application.UserCommands.Users.Queries.GetAllPaginated
{
    internal sealed class GetAllUsersPaginatedQueryHandler : IQueryHandler<GetAllUsersPaginatedQuery, PagedResponse<UserResponseDto?>>
    {
        private readonly IUserRepository _userRepository;

        public GetAllUsersPaginatedQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result<PagedResponse<UserResponseDto?>>> Handle(GetAllUsersPaginatedQuery request, CancellationToken cancellationToken = default)
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
