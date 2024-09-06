using Authentication.Application.Abstractions.Messaging;
using Authentication.Application.Mappers;
using Authentication.Domain.Core.Primitives;
using Authentication.Domain.DTOs.Requests;
using Authentication.Domain.Interfaces.Repository;
using Authentication.Domain.Interfaces.Services;

namespace Authentication.Application.UserCommands.Users.Commands.Update
{
    public sealed class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordService _passwordService;

        public UpdateUserCommandHandler(IUserRepository userRepository, IPasswordService passwordService)
        {
            _userRepository = userRepository;
            _passwordService = passwordService;
        }

        public async Task<Result> Handle(UpdateUserCommand request, CancellationToken cancellationToken = default)
        {
            var user = new UserRequestDto()
            {
                Id = request.Id,
                Username = request.Username,
                Name = request.Name,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Password = request.Password,
                Role = request.Role,
                Status = request.Status,
            };
            var newUser = user.ToModel();

            if(!string.IsNullOrEmpty(request.Password))
            {
                byte[] passwordHash, passwordSalt;
                _passwordService.CreatePasswordHash(user.Password, out passwordHash, out passwordSalt);

                newUser.PasswordHash = passwordHash;
                newUser.PasswordSalt = passwordSalt;
            }

            await _userRepository.Update(newUser, cancellationToken);

            return Result.Success();
        }
    }
}
