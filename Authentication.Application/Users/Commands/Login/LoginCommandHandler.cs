using Digimash.Application.Abstractions.Messaging;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.Interfaces.Repository;
using Digimash.Domain.Entities;
using Digimash.Domain.Core.Errors;
using Digimash.Application.Abstractions;
using Digimash.Domain.Interfaces.Services;
using Digimash.Domain.DTOs.Responses;

namespace Digimash.Application.Users.Commands.Login
{
    internal sealed class LoginCommandHandler : ICommandHandler<LoginCommand, TokenResponseDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IAuthService _authService;
        private readonly IPasswordService _passwordService;

        public LoginCommandHandler(
            IUserRepository userRepository, 
            IJwtProvider jwtProvider, 
            IAuthService authService,
            IPasswordService passwordService)
        {
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _authService = authService;
            _passwordService = passwordService;
        }

        public async Task<Result<TokenResponseDto>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            User user = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);

            if (user is null)
            {
                return Result.Failure<TokenResponseDto>(
                    DomainErrors.User.InvalidCredentials);
            }

            if (!_passwordService.VerifyPassword(user, request.Password))
            {
                return Result.Failure<TokenResponseDto>(
                    DomainErrors.User.InvalidCredentials);
            }

            if (user.EmailVerifiedAt == null)
            {
                return Result.Failure<TokenResponseDto>(
                    DomainErrors.User.UserNotVerified);
            }

            string token = _jwtProvider.Generate(user);
            var newRefreshToken = _authService.CreateRefreshToken();
            user.RefreshToken = newRefreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(1);


            return Result.Success(new TokenResponseDto()
            {
                AccessToken = token,
                RefreshToken = newRefreshToken
            });
        }
    }
}
