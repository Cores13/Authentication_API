using Authentication.Application.Abstractions.Messaging;
using Authentication.Application.Behaviors;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = AssemblyReference.Assembly;

            // Register all command handlers (ICommandHandler<,>) and query handlers (IQueryHandler<,>) using reflection
            var handlerTypes = assembly
                .GetTypes()
                .Where(t => !t.IsAbstract && !t.IsInterface)
                .SelectMany(t => t.GetInterfaces(), (type, iface) => new { type, iface })
                .Where(t =>
                    t.iface.IsGenericType &&
                    (
                        t.iface.GetGenericTypeDefinition() == typeof(ICommandHandler<>) ||
                        t.iface.GetGenericTypeDefinition() == typeof(ICommandHandler<,>) ||
                        t.iface.GetGenericTypeDefinition() == typeof(IQueryHandler<,>)
                    ))
                .Distinct();

            foreach (var handler in handlerTypes)
            {
                services.AddScoped(handler.iface, handler.type);
            }

            // Add FluentValidation validators
            services.AddValidatorsFromAssembly(assembly);

            // Add pipeline behaviors (optional)
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(UnitOfWorkBehavior<,>));

            return services;
        }
    }
}