using Digimash.Application.Abstractions.Messaging;
using Digimash.Domain.Core.Primitives;
using Digimash.Domain.Interfaces.Repository;

namespace Digimash.Application.Users.Commands.Delete
{
    public sealed class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync((int)request.Id, cancellationToken);
            _userRepository.Remove(user);

            return Result.Success();
        }
    }
}
