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

        public async Task<Result<TResponse>> Send<TResponse>(
            IRequest<Result<TResponse>> request,
            CancellationToken cancellationToken = default)
        {
            var handlerDelegate = BuildPipeline(request, cancellationToken);
            return await handlerDelegate();
        }

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
                var requestType = request.GetType(); // LoginCommand
                var handlerType = typeof(IRequestHandler<,>).MakeGenericType(requestType, typeof(Result<TResponse>));

                var handler = _serviceProvider.GetRequiredService(handlerType);

                var method = handlerType.GetMethod("Handle");
                if (method == null)
                {
                    throw new InvalidOperationException($"Handler {handlerType} does not have a Handle method.");
                }

                var task = (Task<Result<TResponse>>)method.Invoke(handler, new object[] { request, cancellationToken });
                return await task;
            };

            foreach (var behavior in behaviors)
            {
                var next = handlerDelegate;
                handlerDelegate = async () => await behavior.Handle(request, next, cancellationToken);
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
                var requestType = request.GetType(); // Concrete command
                var handlerType = typeof(IRequestHandler<,>).MakeGenericType(requestType, typeof(Result));

                var handler = _serviceProvider.GetRequiredService(handlerType);

                var method = handlerType.GetMethod("Handle");
                if (method == null)
                {
                    throw new InvalidOperationException($"Handler {handlerType} does not have a Handle method.");
                }

                var task = (Task<Result>)method.Invoke(handler, new object[] { request, cancellationToken });
                return await task;
            };

            foreach (var behavior in behaviors)
            {
                var next = handlerDelegate;
                handlerDelegate = async () => await behavior.Handle(request, next, cancellationToken);
            }

            return handlerDelegate;
        }
    }
}
