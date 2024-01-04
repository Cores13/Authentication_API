using Digimash.Application.Abstractions.Messaging;
using Digimash.Domain.Core.Errors;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.Enums;
using Digimash.Domain.Interfaces.Repository;
using Digimash.Domain.Interfaces.Services;

namespace Digimash.Application.Password.ForgotPasswordRequest
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
