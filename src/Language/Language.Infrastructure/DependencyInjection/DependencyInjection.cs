using Language.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connection)
    {
        // register your DbContext
        services.AddDbContext<LanguageDbContext>(opts =>
            opts.UseSqlServer(connection, sql => sql.MigrationsAssembly(typeof(LanguageDbContext).Assembly.FullName)));

        // register your repositories / unit-of-work etc.
        // services.AddScoped<IOrderRepository, OrderRepository>();
        // services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
