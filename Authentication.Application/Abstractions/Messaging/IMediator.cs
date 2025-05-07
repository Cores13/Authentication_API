using Authentication.Domain.Core.Primitives;

namespace Authentication.Application.Abstractions.Messaging
{
    public interface IMediator
    {
        // Send method for queries/commands that return a value
        Task<Result<TResponse>> Send<TResponse>(IRequest<Result<TResponse>> request, CancellationToken cancellationToken = default);

        // Send method for commands without a return value
        Task<Result> Send(IRequest<Result> request, CancellationToken cancellationToken = default);
    }
}
