using Digimash.Application.Abstractions.Messaging;
using Digimash.Domain.Core.Errors;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.Enums;
using Digimash.Domain.Interfaces.Repository;
using Digimash.Domain.Interfaces.Services;

namespace Digimash.Application.Password.ForgotPasswordReset
{
    public sealed class ForgotPasswordResetCommandHandler : ICommandHandler<ForgotPasswordResetCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IVerificationCodeService _verificationCodeService;
        private readonly IPasswordService _passwordService;

        public ForgotPasswordResetCommandHandler(IPasswordService passwordService, IUserRepository userRepository, IVerificationCodeService verificationCodeService)
        {
            _userRepository = userRepository;
            _verificationCodeService = verificationCodeService;
            _passwordService = passwordService;
        }

        public async Task<Result> Handle(ForgotPasswordResetCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);

            if (user is null)
            {
                return Result.Failure(
                    DomainErrors.User.DoesNotExist);
            }

            var isCodeValid = await _verificationCodeService.VerifyCodeAsync((int)user.Id, request.Code, VerificationCodeType.PasswordReset, cancellationToken, false);

            if (!isCodeValid)
            {
                return Result.Failure(
                    DomainErrors.VerificationCodes.InvalidOrExpiredCode);
            }

            byte[] passwordHash, passwordSalt;
            _passwordService.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            return Result.Success();
        }
    }
}
