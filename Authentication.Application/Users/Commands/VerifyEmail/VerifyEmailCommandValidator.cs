using Digimash.Application.Users.Commands.VerifyEmail;
using FluentValidation;

namespace Digimash.Application.Users.Commands.VerifyEmail
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
