var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PhoneApp>("phoneapp");

builder.Build().Run();
