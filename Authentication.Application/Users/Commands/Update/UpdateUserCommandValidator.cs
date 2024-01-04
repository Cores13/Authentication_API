using Digimash.Domain.Core.Errors;
using Digimash.Domain.Interfaces.Services;
using FluentValidation;

namespace Digimash.Application.Users.Commands.Update
{
    public sealed class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator(IValidationService validationService)
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
                .MinimumLength(6).When(x => !string.IsNullOrEmpty(x.Password))
                .NotEmpty().When(x => !string.IsNullOrEmpty(x.Password));
        }
    }
}
