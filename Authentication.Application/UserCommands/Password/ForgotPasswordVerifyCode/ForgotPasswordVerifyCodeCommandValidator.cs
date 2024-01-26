using FluentValidation;

namespace Authentication.Application.UserCommands.Password.ForgotPasswordVerifyCode
{
    public sealed class ForgotPasswordVerifyCodeCommandValidator : AbstractValidator<ForgotPasswordVerifyCodeCommand>
    {
        public ForgotPasswordVerifyCodeCommandValidator()
        {
            RuleFor(x => x.Code)
                .NotEmpty()
                .MinimumLength(12);
        }
    }
}
