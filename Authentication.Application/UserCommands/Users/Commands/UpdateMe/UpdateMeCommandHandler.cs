using Authentication.Application.Abstractions.Messaging;
using Authentication.Application.Mappers;
using Authentication.Domain.Core.Primitives;
using Authentication.Domain.DTOs.Requests;
using Authentication.Domain.Interfaces.Repository;
using Authentication.Domain.Interfaces.Services;

namespace Authentication.Application.UserCommands.Users.Commands.UpdateMe
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

        public async Task<Result> Handle(UpdateMeCommand request, CancellationToken cancellationToken = default)
        {
            var user = new UserRequestDto()
            {
                Id = request.Id,
                Username = request.Username,
                Name = request.Name,
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
