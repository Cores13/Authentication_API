using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Primitives;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication.Infrastructure.Services
{
    public class Mediator : IMediator
    {
        private readonly IServiceProvider _serviceProvider;

        public Mediator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        // Send method for requests WITH a response
        public async Task<Result<TResponse>> Send<TResponse>(
            IRequest<Result<TResponse>> request,
            CancellationToken cancellationToken = default)
        {
            var handlerDelegate = BuildPipeline(request, cancellationToken);
            return await handlerDelegate();
        }

        // Send method for requests WITHOUT a response
        public async Task<Result> Send(
            IRequest<Result> request,
            CancellationToken cancellationToken = default)
        {
            var handlerDelegate = BuildPipeline(request, cancellationToken);
            return await handlerDelegate();
        }

        private RequestHandlerDelegate<Result<TResponse>> BuildPipeline<TResponse>(
            IRequest<Result<TResponse>> request,
            CancellationToken cancellationToken)
        {
            var behaviors = _serviceProvider
                .GetServices<IPipelineBehavior<IRequest<Result<TResponse>>, Result<TResponse>>>()
                .Reverse()
                .ToList();

            RequestHandlerDelegate<Result<TResponse>> handlerDelegate = async () =>
            {
                var handlerType = typeof(IRequestHandler<,>).MakeGenericType(request.GetType(), typeof(Result<TResponse>));
                dynamic handler = _serviceProvider.GetRequiredService(handlerType);
                return await handler.HandleAsync((dynamic)request, cancellationToken);
            };

            foreach (var behavior in behaviors)
            {
                var next = handlerDelegate;
                handlerDelegate = () => behavior.Handle(request, next, cancellationToken);
            }

            return handlerDelegate;
        }

        private RequestHandlerDelegate<Result> BuildPipeline(
            IRequest<Result> request,
            CancellationToken cancellationToken)
        {
            var behaviors = _serviceProvider
                .GetServices<IPipelineBehavior<IRequest<Result>, Result>>()
                .Reverse()
                .ToList();

            RequestHandlerDelegate<Result> handlerDelegate = async () =>
            {
                var handlerType = typeof(IRequestHandler<,>).MakeGenericType(request.GetType(), typeof(Result));
                dynamic handler = _serviceProvider.GetRequiredService(handlerType);
                return await handler.HandleAsync((dynamic)request, cancellationToken);
            };

            foreach (var behavior in behaviors)
            {
                var next = handlerDelegate;
                handlerDelegate = () => behavior.Handle(request, next, cancellationToken);
            }

            return handlerDelegate;
        }
    }
}
