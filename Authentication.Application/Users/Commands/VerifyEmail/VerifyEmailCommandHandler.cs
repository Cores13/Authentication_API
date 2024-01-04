using Digimash.Application.Abstractions.Messaging;
using Digimash.Application.Mappers;
using Digimash.Application.Users.Commands.VerifyEmail;
using Digimash.Domain.Core.Errors;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.DTOs.Requests;
using Digimash.Domain.Enums;
using Digimash.Domain.Interfaces.Repository;
using Digimash.Domain.Interfaces.Services;

namespace Digimash.Application.Users.Commands.UpdateMe
{
    public sealed class VerifyEmailCommandHandler : ICommandHandler<VerifyEmailCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IVerificationCodeService _verificationCodeService;

        public VerifyEmailCommandHandler(IUserRepository userRepository, IVerificationCodeService verificationCodeService)
        {
            _userRepository = userRepository;
            _verificationCodeService = verificationCodeService;
        }

        public async Task<Result> Handle(VerifyEmailCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id, cancellationToken);

            if (user is null)
            {
                return Result.Failure(
                    DomainErrors.User.DoesNotExist);
            }

            var isCodeValid = await _verificationCodeService.VerifyCodeAsync((int)user.Id, request.Code, VerificationCodeType.EmailVerification, cancellationToken, false);

            if (!isCodeValid)
            {
                return Result.Failure(
                    DomainErrors.VerificationCodes.InvalidOrExpiredCode);
            }

            user.EmailVerifiedAt = DateTime.UtcNow;

            return Result.Success();
        }
    }
}
