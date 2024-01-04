using Digimash.Application.Abstractions.Messaging;
using Digimash.Application.Mappers;
using Digimash.Domain.Core.Errors;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.DTOs.Requests;
using Digimash.Domain.Enums;
using Digimash.Domain.Interfaces.Repository;
using Digimash.Domain.Interfaces.Services;

namespace Digimash.Application.Users.Commands.Create
{
    internal sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordService _passwordService;
        private readonly IVerificationCodeService _verificationCodeService;

        public CreateUserCommandHandler(IUserRepository userRepository, IPasswordService passwordService, IVerificationCodeService verificationCodeService)
        {
            _userRepository = userRepository;
            _passwordService = passwordService;
            _verificationCodeService = verificationCodeService;
        }

        public async Task<Result> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            if (!Enum.IsDefined(typeof(UserRoleEnum), request.Role))
            {
                return Result.Failure(
                    DomainErrors.User.InvalidRole);
            }

            var user = new UserRequestDto()
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                Role = request.Role
            };
            var newUser = user.ToModel();

            byte[] passwordHash, passwordSalt;
            _passwordService.CreatePasswordHash(user.Password, out passwordHash, out passwordSalt);

            newUser.PasswordHash = passwordHash;
            newUser.PasswordSalt = passwordSalt;

            _userRepository.Add(newUser);
            _userRepository.GetAddedEntity(newUser);

            await _verificationCodeService.CreateCodeAsync((int)newUser.Id, VerificationCodeType.EmailVerification, cancellationToken);

            return Result.Success();
        }
    }
}
