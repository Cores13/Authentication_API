using FluentValidation;

namespace Authentication.Application.UserCommands.Password.ForgotPasswordRequest
{
    public sealed class ForgotPasswordRequestCommandValidator : AbstractValidator<ForgotPasswordRequestCommand>
    {
        public ForgotPasswordRequestCommandValidator()
        {
            RuleFor(x => x.Email).NotEmpty();
        }
    }
}
