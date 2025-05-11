using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace Language.Infrastructure.Data;

public class LanguageDbContextFactory : IDesignTimeDbContextFactory<LanguageDbContext>
{
    public LanguageDbContext CreateDbContext(string[] args)
    {
        // locate appsettings.json in your API output folder
        var basePath = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().Location)!;

        var config = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: false)
            //.AddJsonFile(
            //   $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
            //   optional: true)
            .Build();

        var builder = new DbContextOptionsBuilder<LanguageDbContext>();
        var conn = config.GetConnectionString("DefaultConnection")
                   ?? throw new InvalidOperationException(
                       "No DefaultConnection in appsettings.json");

        builder.UseSqlServer(conn,
            sql => sql.MigrationsAssembly(typeof(LanguageDbContext).Assembly.FullName));

        return new LanguageDbContext(builder.Options);
    }
}
