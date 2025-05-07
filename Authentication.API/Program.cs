using Authentication.Application;
using Authentication.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Authentication.API.OptionsSetup;
using Serilog;
using Authentication.Application.Behaviors;
using Authentication.API.Middleware;
using FluentValidation;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddApplication()
    //.AddMediator()
    .AddInfrastructure(builder.Configuration);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer();



builder.Services.ConfigureOptions<EmailOptionsSetup>();
builder.Services.ConfigureOptions<JwtOptionsSetup>();
builder.Services.ConfigureOptions<JwtBearerOptionsSetup>();

builder.Services.AddValidatorsFromAssembly(AssemblyReference.Assembly,
    includeInternalTypes: true);

builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection(); // Change before production
}

app.UseSerilogRequestLogging();

app.UseCors(builder => builder
     .AllowAnyOrigin()
     //.WithOrigins("http://localhost:3000", "https://Authentication-web.azurewebsites.net")
     .AllowAnyMethod()
     .AllowAnyHeader());


app.UseMiddleware(typeof(ErrorHandlerMiddleware));

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
