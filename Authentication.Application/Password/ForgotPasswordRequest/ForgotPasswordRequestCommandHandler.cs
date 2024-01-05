using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Errors;
using Authentication.Domain.Core.Primitives;
using Authentication.Domain.Enums;
using Authentication.Domain.Interfaces.Repository;
using Authentication.Domain.Interfaces.Services;

namespace Authentication.Application.Password.ForgotPasswordRequest
{
    public sealed class ForgotPasswordRequestCommandHandler : ICommandHandler<ForgotPasswordRequestCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IVerificationCodeService _verificationCodeService;

        public ForgotPasswordRequestCommandHandler(IUserRepository userRepository, IVerificationCodeService verificationCodeService)
        {
            _userRepository = userRepository;
            _verificationCodeService = verificationCodeService;
        }

        public async Task<Result> Handle(ForgotPasswordRequestCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);

            if (user is null)
            {
                return Result.Failure(
                    DomainErrors.User.DoesNotExist);
            }

            await _verificationCodeService.CreateCodeAsync((int)user.Id, VerificationCodeType.PasswordReset, cancellationToken);

            return Result.Success();
        }
    }
}
