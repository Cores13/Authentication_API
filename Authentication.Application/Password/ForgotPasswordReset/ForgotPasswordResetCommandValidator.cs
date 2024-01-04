using FluentValidation;

namespace Digimash.Application.Password.ForgotPasswordReset
{
    public sealed class ForgotPasswordResetCommandValidator : AbstractValidator<ForgotPasswordResetCommand>
    {
        public ForgotPasswordResetCommandValidator()
        {
            RuleFor(x => x.Code)
              .NotEmpty()
              .MinimumLength(4);

            RuleFor(x => x.Password)
                .MinimumLength(6)
                .NotEmpty();
        }
    }
}
