using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Errors;
using Authentication.Domain.Core.Primitives;
using Authentication.Domain.DTOs.Responses;
using Authentication.Domain.Enums;
using Authentication.Domain.Interfaces.Repository;
using Authentication.Domain.Interfaces.Services;

namespace Authentication.Application.UserCommands.Users.Commands.ResendVerificationEmail
{
    public sealed class ResendVerificationEmailCommandHandler : ICommandHandler<ResendVerificationEmailCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IVerificationCodeService _verificationCodeService;

        public ResendVerificationEmailCommandHandler(IUserRepository userRepository, IVerificationCodeService verificationCodeService)
        {
            _userRepository = userRepository;
            _verificationCodeService = verificationCodeService;
        }

        public async Task<Result> Handle(ResendVerificationEmailCommand request, CancellationToken cancellationToken = default)
        {
            var user = await _userRepository.GetByIdAsync(request.Id, cancellationToken);

            if (user is null || user.EmailVerifiedAt is not null)
            {
                return Result.Failure<TokenResponseDto>(
                    DomainErrors.User.InvalidRequest);
            }

            await _verificationCodeService.CreateCodeAsync((int)user.Id, VerificationCodeType.EmailVerification, cancellationToken);
            
            return Result.Success();
        }
    }
}
