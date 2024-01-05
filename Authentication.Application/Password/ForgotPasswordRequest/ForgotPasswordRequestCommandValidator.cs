using Authentication.Domain.Enums;
using Authentication.Domain.Interfaces.Services;
using FluentValidation;

namespace Authentication.Application.Password.ForgotPasswordRequest
{
    public sealed class ForgotPasswordRequestCommandValidator : AbstractValidator<ForgotPasswordRequestCommand>
    {
        public ForgotPasswordRequestCommandValidator()
        {
            RuleFor(x => x.Email).NotEmpty();
        }
    }
}
