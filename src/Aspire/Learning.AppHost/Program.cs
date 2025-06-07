var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql")
                .WithLifetime(ContainerLifetime.Persistent)
                .WithDataVolume();

var db = sql.AddDatabase("LanguageDb");

var languageAPI = builder.AddProject<Projects.Language_API>("LanguageAPI")
      .WithReference(db)
      .WaitFor(db);

builder.Build().Run();
