using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Authentication.Infrastructure.Database;
using Microsoft.AspNetCore.Builder;
using Authentication.Domain.Interfaces.Repository;
using Authentication.Infrastructure.Repository;
using Authentication.Domain.Interfaces.Services;
using Authentication.Infrastructure.Services;
using Authentication.Application.Abstractions;
using Authentication.Infrastructure.Options.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Authentication.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("Default"),
                    ctxOptions =>
                    {
                        // ctxOptions.MaxBatchSize(1000);
                        // ctxOptions.EnableRetryOnFailure();
                        ctxOptions.MigrationsAssembly("Authentication.Infrastructure");
                        // ctxOptions.UseNetTopologySuite();
                        ctxOptions.CommandTimeout(180);
                    }
                ).EnableSensitiveDataLogging();
            });

            services.AddScoped<IValidationService, ValidationService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IJwtProvider, JwtProvider>();
            services.AddScoped<IPasswordService, PasswordService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IVerificationCodeService, VerificationCodeService>();
            services.AddScoped<IEmailService, EmailService>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }

        public static void UseProjectSqlServer(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}