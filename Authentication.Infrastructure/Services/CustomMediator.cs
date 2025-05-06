using Authentication.Application.Abstractions.Messaging;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication.Infrastructure.Services
{
    public class CustomMediator : IMediator
    {
        private readonly IServiceProvider _serviceProvider;

        public CustomMediator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            // Resolves the correct handler based on the request type
            var handler = _serviceProvider.GetRequiredService<IRequestHandler<IRequest<TResponse>, TResponse>>();
            return await handler.HandleAsync(request, cancellationToken);
        }

        public Task Publish(object notification, CancellationToken cancellationToken = default)
        {
            // No-op since we don't handle notifications
            return Task.CompletedTask;
        }

        public Task<object> Send(object request, CancellationToken cancellationToken = default)
        {
            // Getting the request and handler types dynamically
            var requestType = request.GetType();
            var handlerType = typeof(IRequestHandler<,>).MakeGenericType(request.GetType(), request.GetType());
            var handler = _serviceProvider.GetRequiredService(handlerType);

            // Find the 'HandleAsync' method
            var method = handlerType.GetMethod("HandleAsync");

            if (method == null)
            {
                throw new InvalidOperationException($"Handler for {requestType.Name} does not implement HandleAsync.");
            }

            // Invoke the handler method dynamically
            return (Task<object>)method.Invoke(handler, new object[] { request, cancellationToken });
        }
    }
}
