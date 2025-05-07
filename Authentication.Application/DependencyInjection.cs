using Authentication.Application.Abstractions.Messaging;
using Authentication.Application.Behaviors;
using Authentication.Domain.Core.Primitives;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Authentication.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = AssemblyReference.Assembly;

            var handlerTypes = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract &&
                    (t.GetInterfaces().Any(i => i.IsGenericType && (
                        i.GetGenericTypeDefinition() == typeof(ICommandHandler<,>) ||
                        i.GetGenericTypeDefinition() == typeof(ICommandHandler<>) ||
                        i.GetGenericTypeDefinition() == typeof(IRequestHandler<,>) ||
                        i.GetGenericTypeDefinition() == typeof(IQueryHandler<,>)
                    ))))
                .ToList();

            foreach (var handlerType in handlerTypes)
            {
                // Handle ICommandHandler<TCommand, TResponse>
                var commandHandlerInterface = handlerType.GetInterfaces()
                    .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<,>));

                if (commandHandlerInterface != null)
                {
                    var commandType = commandHandlerInterface.GetGenericArguments()[0];
                    var responseType = commandHandlerInterface.GetGenericArguments()[1];

                    var genericCommandHandlerType = typeof(ICommandHandler<,>).MakeGenericType(commandType, responseType);
                    services.AddScoped(genericCommandHandlerType, handlerType);

                    // ALSO register as IRequestHandler<TCommand, Result<TResponse>>
                    var genericRequestHandlerType = typeof(IRequestHandler<,>).MakeGenericType(
                        commandType,
                        typeof(Result<>).MakeGenericType(responseType)
                    );
                    services.AddScoped(genericRequestHandlerType, handlerType);
                }

                // Handle ICommandHandler<TCommand> (commands with no return)
                var commandHandlerNoResponseInterface = handlerType.GetInterfaces()
                    .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<>));

                if (commandHandlerNoResponseInterface != null)
                {
                    var commandType = commandHandlerNoResponseInterface.GetGenericArguments()[0];

                    var genericCommandHandlerType = typeof(ICommandHandler<>).MakeGenericType(commandType);
                    services.AddScoped(genericCommandHandlerType, handlerType);

                    // ALSO register as IRequestHandler<TCommand, Result>
                    var genericRequestHandlerType = typeof(IRequestHandler<,>).MakeGenericType(
                        commandType,
                        typeof(Result)
                    );
                    services.AddScoped(genericRequestHandlerType, handlerType);
                }

                // Handle IRequestHandler<TRequest, TResponse> (direct request handlers)
                var requestHandlerInterface = handlerType.GetInterfaces()
                    .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequestHandler<,>));

                if (requestHandlerInterface != null)
                {
                    services.AddScoped(requestHandlerInterface, handlerType);
                }

                // Handle IQueryHandler<TQuery, TResponse>
                var queryHandlerInterface = handlerType.GetInterfaces()
                    .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IQueryHandler<,>));

                if (queryHandlerInterface != null)
                {
                    var queryType = queryHandlerInterface.GetGenericArguments()[0];
                    var responseType = queryHandlerInterface.GetGenericArguments()[1];

                    var genericQueryHandlerType = typeof(IQueryHandler<,>).MakeGenericType(queryType, responseType);
                    services.AddScoped(genericQueryHandlerType, handlerType);

                    // ALSO register as IRequestHandler<TQuery, Result<TResponse>>
                    var genericRequestHandlerType = typeof(IRequestHandler<,>).MakeGenericType(
                        queryType,
                        typeof(Result<>).MakeGenericType(responseType)
                    );
                    services.AddScoped(genericRequestHandlerType, handlerType);
                }
            }

            // Add FluentValidation validators
            services.AddValidatorsFromAssembly(assembly, includeInternalTypes: true);

            services.AddMemoryCache();

            // Register pipeline behaviors
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingPipelineBehavior<,>));
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(CachingPipelineBehavior<,>));
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(UnitOfWorkBehavior<,>));

            return services;
        }
    }
}
