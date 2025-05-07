using Authentication.Application.Abstractions.Messaging;
using Authentication.Application.Behaviors;
using FluentValidation;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Authentication.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = AssemblyReference.Assembly;

            // Register all command handlers (ICommandHandler<,>) and query handlers (IQueryHandler<,>) using reflection
            //var handlerTypes = assembly
            //    .GetTypes()
            //    .Where(t => !t.IsAbstract && !t.IsInterface)
            //    .SelectMany(t => t.GetInterfaces(), (type, iface) => new { type, iface })
            //    .Where(t =>
            //        t.iface.IsGenericType &&
            //        (
            //            t.iface.GetGenericTypeDefinition() == typeof(ICommandHandler<>) ||
            //            t.iface.GetGenericTypeDefinition() == typeof(ICommandHandler<,>) ||
            //            t.iface.GetGenericTypeDefinition() == typeof(IRequestHandler<,>) ||
            //            t.iface.GetGenericTypeDefinition() == typeof(IQueryHandler<,>)
            //        ))
            //    .Distinct();

            //foreach (var handler in handlerTypes)
            //{
            //    services.AddScoped(handler.iface, handler.type);
            //}

            // Register ICommandHandler<TCommand> and ICommandHandler<TCommand, TResponse>
            var handlerTypes = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract &&
                            (t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<,>)) ||
                             t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<>)) ||
                             t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequestHandler<,>)) ||
                             t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IQueryHandler<,>))))
                .ToList();

            foreach (var handlerType in handlerTypes)
            {
                // Register ICommandHandler<TCommand, TResponse>
                var commandHandlerInterface = handlerType.GetInterfaces()
                    .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<,>));

                if (commandHandlerInterface != null)
                {
                    var commandType = commandHandlerInterface.GetGenericArguments()[0]; // TCommand
                    var responseType = commandHandlerInterface.GetGenericArguments()[1]; // TResponse

                    var genericCommandHandlerType = typeof(ICommandHandler<,>).MakeGenericType(commandType, responseType);
                    services.AddTransient(genericCommandHandlerType, handlerType);
                }

                // Register ICommandHandler<TCommand> (for commands with no return type)
                var commandHandlerInterfaceNoResponse = handlerType.GetInterfaces()
                    .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<>));

                if (commandHandlerInterfaceNoResponse != null)
                {
                    var commandType = commandHandlerInterfaceNoResponse.GetGenericArguments()[0]; // TCommand
                    var genericCommandHandlerType = typeof(ICommandHandler<>).MakeGenericType(commandType);
                    services.AddTransient(genericCommandHandlerType, handlerType);
                }

                // Register IRequestHandler<TRequest, TResponse> (for request handlers)
                var requestHandlerInterface = handlerType.GetInterfaces()
                    .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequestHandler<,>));

                if (requestHandlerInterface != null)
                {
                    var requestType = requestHandlerInterface.GetGenericArguments()[0]; // TRequest
                    var responseType = requestHandlerInterface.GetGenericArguments()[1]; // TResponse

                    var genericRequestHandlerType = typeof(IRequestHandler<,>).MakeGenericType(requestType, responseType);
                    services.AddTransient(genericRequestHandlerType, handlerType);
                }

                // Register IQueryHandler<TQuery, TResponse> (for query handlers)
                var queryHandlerInterface = handlerType.GetInterfaces()
                    .FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IQueryHandler<,>));

                if (queryHandlerInterface != null)
                {
                    var queryType = queryHandlerInterface.GetGenericArguments()[0]; // TQuery
                    var responseType = queryHandlerInterface.GetGenericArguments()[1]; // TResponse

                    var genericQueryHandlerType = typeof(IQueryHandler<,>).MakeGenericType(queryType, responseType);
                    services.AddTransient(genericQueryHandlerType, handlerType);
                }
            }

            // Add FluentValidation validators
            services.AddValidatorsFromAssembly(assembly);

            services.AddScoped(
                typeof(IPipelineBehavior<,>),
                typeof(LoggingPipelineBehavior<,>));

            services.AddScoped(
                typeof(IPipelineBehavior<,>),
                typeof(ValidationPipelineBehavior<,>));

            services.AddScoped(
            typeof(IPipelineBehavior<,>),
                typeof(UnitOfWorkBehavior<,>));

            return services;
        }

        public static IServiceCollection AddMediator(this IServiceCollection services, params Assembly[] assemblies)
        {
            var types = assemblies.SelectMany(a => a.GetTypes()).ToList();

            foreach (var type in types)
            {
                var interfaces = type.GetInterfaces();

                foreach (var @interface in interfaces)
                {
                    if (!@interface.IsGenericType) continue;

                    var genericType = @interface.GetGenericTypeDefinition();

                    if (genericType == typeof(IRequestHandler<,>) ||
                        genericType == typeof(ICommandHandler<,>) ||
                        genericType == typeof(ICommandHandler<>) ||
                        genericType == typeof(IQueryHandler<,>))
                    {
                        services.AddTransient(@interface, type);
                    }
                }
            }

            return services; // <-- ADD THIS!
        }
    }
}