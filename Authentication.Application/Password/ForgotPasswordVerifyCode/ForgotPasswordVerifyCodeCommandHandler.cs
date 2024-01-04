using Digimash.Application.Abstractions.Messaging;
using Digimash.Domain.Core.Errors;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.Enums;
using Digimash.Domain.Interfaces.Repository;
using Digimash.Domain.Interfaces.Services;

namespace Digimash.Application.Password.ForgotPasswordVerifyCode
{
    public sealed class ForgotPasswordVerifyCodeCommandHandler : ICommandHandler<ForgotPasswordVerifyCodeCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IVerificationCodeService _verificationCodeService;

        public ForgotPasswordVerifyCodeCommandHandler(IUserRepository userRepository, IVerificationCodeService verificationCodeService)
        {
            _userRepository = userRepository;
            _verificationCodeService = verificationCodeService;
        }

        public async Task<Result> Handle(ForgotPasswordVerifyCodeCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);

            if (user is null)
            {
                return Result.Failure(
                    DomainErrors.User.DoesNotExist);
            }

            var isCodeValid = await _verificationCodeService.VerifyCodeAsync((int)user.Id, request.Code, VerificationCodeType.PasswordReset, cancellationToken, true);

            if (!isCodeValid)
            {
                return Result.Failure(
                    DomainErrors.VerificationCodes.InvalidOrExpiredCode);
            }

            return Result.Success();
        }
    }
}
