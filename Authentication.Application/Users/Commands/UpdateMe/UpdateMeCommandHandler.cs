using Digimash.Application.Abstractions.Messaging;
using Digimash.Application.Mappers;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.DTOs.Requests;
using Digimash.Domain.Interfaces.Repository;
using Digimash.Domain.Interfaces.Services;

namespace Digimash.Application.Users.Commands.UpdateMe
{
    public sealed class UpdateMeCommandHandler : ICommandHandler<UpdateMeCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordService _passwordService;

        public UpdateMeCommandHandler(IUserRepository userRepository, IPasswordService passwordService)
        {
            _userRepository = userRepository;
            _passwordService = passwordService;
        }

        public async Task<Result> Handle(UpdateMeCommand request, CancellationToken cancellationToken)
        {
            var user = new UserRequestDto()
            {
                Id = request.Id,
                Name = request.Name,
                Email = request.Email,
                Password = request.Password
            };
            var newUser = user.ToModel();

            if(!string.IsNullOrEmpty(request.Password))
            {
                byte[] passwordHash, passwordSalt;
                _passwordService.CreatePasswordHash(user.Password, out passwordHash, out passwordSalt);

                newUser.PasswordHash = passwordHash;
                newUser.PasswordSalt = passwordSalt;
            }

            _userRepository.Update(newUser, cancellationToken);

            return Result.Success();
        }
    }
}
