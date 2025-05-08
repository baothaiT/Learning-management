using Learning.ServiceDefaults.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();
builder.Services.AddCORS();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    {
        options.RoutePrefix = string.Empty; // Set Swagger UI at the app's root
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
        
    });
}
app.UseCors("AllowAllOrigins");
app.UseRouting();
app.UseHttpsRedirection();
app.MapControllers();


app.Run();

