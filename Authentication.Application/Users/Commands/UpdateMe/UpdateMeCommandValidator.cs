using Digimash.Domain.Core.Errors;
using Digimash.Domain.Interfaces.Services;
using FluentValidation;

namespace Digimash.Application.Users.Commands.UpdateMe
{
    public sealed class UpdateMeCommandValidator : AbstractValidator<UpdateMeCommand>
    {
        public UpdateMeCommandValidator(IValidationService validationService)
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
