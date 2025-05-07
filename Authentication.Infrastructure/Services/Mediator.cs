using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Primitives;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication.Infrastructure.Services
{
    public sealed class Mediator : IMediator
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
            var requestType = request.GetType();
            var handlerType = typeof(IRequestHandler<,>).MakeGenericType(requestType, typeof(Result<TResponse>));

            var behaviors = _serviceProvider
                .GetServices(typeof(IPipelineBehavior<,>).MakeGenericType(requestType, typeof(Result<TResponse>)))
                .Cast<object>()
                .Reverse()
                .ToList();

            RequestHandlerDelegate<Result<TResponse>> handlerDelegate = async () =>
            {
                var handler = _serviceProvider.GetRequiredService(handlerType);
                var method = handlerType.GetMethod("Handle");

                if (method == null)
                    throw new InvalidOperationException($"Handler {handlerType.Name} does not have a Handle method.");

                var task = (Task<Result<TResponse>>)method.Invoke(handler, new object[] { request, cancellationToken })!;
                return await task;
            };

            foreach (var behavior in behaviors)
            {
                var next = handlerDelegate;
                handlerDelegate = () => InvokeBehaviorAsync<Result<TResponse>>(behavior, request, next, cancellationToken);
            }

            return handlerDelegate;
        }

        private RequestHandlerDelegate<Result> BuildPipeline(
            IRequest<Result> request,
            CancellationToken cancellationToken)
        {
            var requestType = request.GetType();
            var handlerType = typeof(IRequestHandler<,>).MakeGenericType(requestType, typeof(Result));

            var behaviors = _serviceProvider
                .GetServices(typeof(IPipelineBehavior<,>).MakeGenericType(requestType, typeof(Result)))
                .Cast<object>()
                .Reverse()
                .ToList();

            RequestHandlerDelegate<Result> handlerDelegate = async () =>
            {
                var handler = _serviceProvider.GetRequiredService(handlerType);
                var method = handlerType.GetMethod("Handle");

                if (method == null)
                    throw new InvalidOperationException($"Handler {handlerType.Name} does not have a Handle method.");

                var task = (Task<Result>)method.Invoke(handler, new object[] { request, cancellationToken })!;
                return await task;
            };

            foreach (var behavior in behaviors)
            {
                var next = handlerDelegate;
                handlerDelegate = () => InvokeBehaviorAsync<Result>(behavior, request, next, cancellationToken);
            }

            return handlerDelegate;
        }

        private static async Task<TResponse> InvokeBehaviorAsync<TResponse>(
            object behavior,
            object request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            var method = behavior.GetType().GetMethod("Handle");

            if (method == null)
                throw new InvalidOperationException($"Behavior {behavior.GetType().Name} does not have a Handle method.");

            var task = (Task<TResponse>)method.Invoke(behavior, new object[] { request, next, cancellationToken })!;
            return await task;
        }
    }
}
