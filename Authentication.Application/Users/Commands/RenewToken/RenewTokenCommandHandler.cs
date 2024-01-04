using Digimash.Application.Abstractions.Messaging;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.Interfaces.Repository;
using Digimash.Domain.Entities;
using Digimash.Domain.Core.Errors;
using Digimash.Application.Abstractions;
using Digimash.Domain.Interfaces.Services;
using Digimash.Domain.DTOs.Responses;

namespace Digimash.Application.Users.Commands.RenewToken
{
    internal sealed class RenewTokenCommandHandler : ICommandHandler<RenewTokenCommand, TokenResponseDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IAuthService _authService;

        public RenewTokenCommandHandler(IUserRepository userRepository, IJwtProvider jwtProvider, IAuthService authService)
        {
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _authService = authService;
        }

        public async Task<Result<TokenResponseDto>> Handle(RenewTokenCommand request, CancellationToken cancellationToken)
        {
            string accessToken = request.AccessToken;
            string refreshToken = request.RefreshToken;

            var principal = _authService.GetPrincipleFromExpiredToken(accessToken);
            var id = int.Parse(principal?.Identity?.Name);
            User user = await _userRepository.GetByIdAsync(id, cancellationToken);

            if (user is null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            {
                return Result.Failure<TokenResponseDto>(
                    DomainErrors.User.InvalidRequest);
            }
            var newAccessToken = _jwtProvider.Generate(user);
            var newRefreshToken = _authService.CreateRefreshToken();

            user.RefreshToken = newRefreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(1);

            return Result.Success(new TokenResponseDto()
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken
            });
        }
    }
}
