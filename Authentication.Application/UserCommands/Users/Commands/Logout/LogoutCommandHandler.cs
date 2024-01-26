using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Primitives;
using Authentication.Domain.Interfaces.Repository;
using Authentication.Domain.Core.Errors;

namespace Authentication.Application.UserCommands.Users.Commands.Logout
{
    internal sealed class LogoutCommandHandler : ICommandHandler<LogoutCommand>
    {
        private readonly IUserRepository _userRepository;

        public LogoutCommandHandler(
            IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result> Handle(LogoutCommand request, CancellationToken cancellationToken = default)
        {
            var user = await _userRepository.GetByIdAsync(request.Id, cancellationToken);

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
