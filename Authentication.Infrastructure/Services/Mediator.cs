using Authentication.Application.Abstractions.Messaging;
using Authentication.Domain.Core.Primitives;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Authentication.Infrastructure.Services
{
    public class Mediator : IMediator
    {
        private readonly IServiceProvider _serviceProvider;

        public Mediator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        // Main entry point for sending requests
        public async Task<Result<TResponse>> Send<TResponse>(IRequest<Result<TResponse>> request, CancellationToken cancellationToken = default)
        {
            var handlerDelegate = BuildPipeline(request, cancellationToken);
            return await handlerDelegate();
        }

        private RequestHandlerDelegate<Result<TResponse>> BuildPipeline<TResponse>(
            IRequest<Result<TResponse>> request,
            CancellationToken cancellationToken)
        {
            // Get all pipeline behaviors to apply before/after the handler
            var behaviors = _serviceProvider
                .GetServices<IPipelineBehavior<IRequest<Result<TResponse>>, Result<TResponse>>>()
                .Reverse()
                .ToList();

            // Start the handler delegate for the pipeline
            RequestHandlerDelegate<Result<TResponse>> handlerDelegate = async () =>
            {
                // If the request is a command with a response (ICommand<TResponse>)
                if (request is ICommand<TResponse> command)
                {
                    var handlerType = typeof(IRequestHandler<,>).MakeGenericType(command.GetType(), typeof(Result<TResponse>));
                    dynamic handler = _serviceProvider.GetRequiredService(handlerType);
                    return await handler.HandleAsync((dynamic)command, cancellationToken);
                }

                // If the request is a command without a response (ICommand)
                if (request is ICommand commandWithoutResponse)
                {
                    var handlerType = typeof(IRequestHandler<,>).MakeGenericType(commandWithoutResponse.GetType(), typeof(Result));
                    dynamic handler = _serviceProvider.GetRequiredService(handlerType);
                    await handler.HandleAsync((dynamic)commandWithoutResponse, cancellationToken);
                    return Result.Success<TResponse>(default); // Return a default result (no response for ICommand)
                }

                // If it's a regular request without a command (IRequest)
                if (request is IRequest<TResponse> query)
                {
                    var handlerType = typeof(IRequestHandler<,>).MakeGenericType(query.GetType(), typeof(Result<TResponse>));
                    dynamic handler = _serviceProvider.GetRequiredService(handlerType);
                    return await handler.HandleAsync((dynamic)query, cancellationToken);
                }

                // Throw if unknown request type
                throw new InvalidOperationException($"Unknown request type: {request.GetType().Name}");
            };

            // Apply pipeline behaviors in reverse order
            foreach (var behavior in behaviors)
            {
                var next = handlerDelegate;
                handlerDelegate = () => behavior.Handle(request, next, cancellationToken);
            }

            return handlerDelegate;
        }
    }
}
}
