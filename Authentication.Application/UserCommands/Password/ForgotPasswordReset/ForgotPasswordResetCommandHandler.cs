using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Errors;
using Authentication.Domain.Core.Primitives;
using Authentication.Domain.Enums;
using Authentication.Domain.Interfaces.Repository;
using Authentication.Domain.Interfaces.Services;

namespace Authentication.Application.UserCommands.Password.ForgotPasswordReset
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

        public async Task<Result> Handle(ForgotPasswordResetCommand request, CancellationToken cancellationToken = default)
        {
            var user = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);

            if (user is null)
            {
                return Result.Failure(
                    DomainErrors.User.DoesNotExist);
            }

            var isCodeValid = await _verificationCodeService.VerifyCodeAsync((int)user.Id, request.Code, VerificationCodeType.PasswordReset, true, cancellationToken);

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
