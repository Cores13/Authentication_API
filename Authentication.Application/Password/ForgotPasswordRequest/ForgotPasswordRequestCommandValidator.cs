using Digimash.Domain.Enums;
using Digimash.Domain.Interfaces.Services;
using FluentValidation;

namespace Digimash.Application.Password.ForgotPasswordRequest
{
    public sealed class ForgotPasswordRequestCommandValidator : AbstractValidator<ForgotPasswordRequestCommand>
    {
        public ForgotPasswordRequestCommandValidator()
        {
            RuleFor(x => x.Email).NotEmpty();
        }
    }
}
