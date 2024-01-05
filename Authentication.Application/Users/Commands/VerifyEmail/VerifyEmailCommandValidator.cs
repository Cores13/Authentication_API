using FluentValidation;

namespace Authentication.Application.Users.Commands.VerifyEmail
{
    public sealed class VerifyEmailCommandValidator : AbstractValidator<VerifyEmailCommand>
    {
        public VerifyEmailCommandValidator()
        {
            RuleFor(x => x.Code)
                .NotEmpty()
                .MinimumLength(4);
        }
    }
}
