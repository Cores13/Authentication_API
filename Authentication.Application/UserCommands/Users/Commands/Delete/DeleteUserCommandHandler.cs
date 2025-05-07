using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Primitives;
using Authentication.Domain.Interfaces.Repository;

namespace Authentication.Application.UserCommands.Users.Commands.Delete
{
    public sealed class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result> Handle(DeleteUserCommand request, CancellationToken cancellationToken = default)
        {
            var user = await _userRepository.GetByIdAsync((int)request.Id, cancellationToken);
            _userRepository.Remove(user);

            return Result.Success();
        }
    }
}
