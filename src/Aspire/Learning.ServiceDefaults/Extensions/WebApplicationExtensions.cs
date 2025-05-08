using System;
using Microsoft.AspNetCore.Builder;

namespace Learning.ServiceDefaults.Extensions;

public static class WebApplicationExtensions
{
    public static WebApplication AddSwagger(this WebApplication app)
    {
        app.MapOpenApi();
        app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
        {
            options.RoutePrefix = string.Empty; // Set Swagger UI at the app's root
            options.SwaggerEndpoint("/openapi/v1.json", "v1");
            
        });
        return app;
    }


    public static WebApplication UseCORS(this WebApplication app)
    {
        app.UseCors(Contants.AllowAllOrigins);
        return app;
    }
}
