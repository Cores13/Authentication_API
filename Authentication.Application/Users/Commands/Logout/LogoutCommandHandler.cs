using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Primitives;
using Authentication.Domain.Interfaces.Repository;
using Authentication.Domain.Entities;
using Authentication.Domain.Core.Errors;
using Authentication.Application.Abstractions;
using Authentication.Domain.Interfaces.Services;
using Authentication.Domain.DTOs.Responses;

namespace Authentication.Application.Users.Commands.Logout
{
    internal sealed class LogoutCommandHandler : ICommandHandler<LogoutCommand>
    {
        private readonly IUserRepository _userRepository;

        public LogoutCommandHandler(
            IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            User user = await _userRepository.GetByIdAsync(request.Id, cancellationToken);

            if (user is null)
            {
                return Result.Failure(
                    DomainErrors.User.InvalidCredentials);
            }

            user.RefreshToken = null;
            user.RefreshTokenExpiryTime = DateTime.UtcNow;


            return Result.Success();
        }
    }
}
