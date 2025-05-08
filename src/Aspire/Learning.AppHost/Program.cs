var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql")
                 .WithDataVolume();

var db = sql.AddDatabase("database");

var languageAPI = builder.AddProject<Projects.Language_API>("LanguageAPI")
       .WithReference(db)
       .WaitFor(db);

builder.Build().Run();
