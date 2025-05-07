using Authentication.Domain.Core.Primitives;

namespace Authentication.Application.Abstractions.Messaging;
public interface IMediator
{
    Task<Result<TResponse>> Send<TResponse>(IRequest<Result<TResponse>> request, CancellationToken cancellationToken = default);
}

