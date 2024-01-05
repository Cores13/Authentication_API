using Authentication.Domain.Core.Errors;
using Authentication.Domain.Interfaces.Services;
using FluentValidation;

namespace Authentication.Application.Users.Commands.Create
{
    public sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator(IValidationService validationService)
        {
            RuleFor(x => x.Name)
                .NotEmpty();

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                .Must((request, x) =>
                {
                    return validationService.IsUserEmailUnique(request.Email);
                }).WithMessage(DomainErrors.Email.EmailInUse.Message);

            RuleFor(x => x.Password)
                .MinimumLength(6).When(x => x.Password != null)
                .NotEmpty().When(x => x.Password != null);
        }
    }
}
