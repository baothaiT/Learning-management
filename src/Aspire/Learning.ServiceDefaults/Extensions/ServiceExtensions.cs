using System;
using Microsoft.Extensions.DependencyInjection;

namespace Learning.ServiceDefaults.Extensions;

public static class ServiceExtensions
{

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        // Register your services here
        // Example: services.AddScoped<IMyService, MyService>();
        return services;
    }

    public static IServiceCollection AddSwagger(this IServiceCollection services)
    {

        return services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "My API", Version = "v1" });
        });
    }
    public static IServiceCollection AddCORS(this IServiceCollection services)
    {
        return services.AddCors(options =>
        {
            options.AddPolicy(Contants.AllowAllOrigins,
                builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
        });
    }
}
