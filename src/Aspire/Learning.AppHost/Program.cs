var builder = DistributedApplication.CreateBuilder(args);

var languageAPI = builder.AddProject<Projects.LanguageAPI>("LanguageAPI");

builder.Build().Run();
