using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Learning.ServiceDefaults.Extensions;

public class ConfigurationBuilderExtensions
{
    public static IConfigurationRoot GetAppSetting()
    {
        // locate appsettings.json in your API output folder
        var basePath = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().Location)!;
        var config = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile( $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true)
            .Build();
        return config;
    }
}
