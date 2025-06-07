

using Language.Infrastructure.Data;
using Learning.ServiceDefaults.Extensions;
using Microsoft.EntityFrameworkCore;
using Language.Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers(options =>
{
    options.SuppressAsyncSuffixInActionNames = false;
});
//builder.AddServiceDefaults();
var config = ConfigurationBuilderExtensions.GetAppSetting();
string DefaultConnection = config.GetConnectionString("LanguageDb");
builder.Services.AddInfrastructure(DefaultConnection);

builder.Services.AddSwagger();
builder.Services.AddCORS();
builder.Services.AddServices();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.AddSwagger();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}
app.UseCORS();
app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
