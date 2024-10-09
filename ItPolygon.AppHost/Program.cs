var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AuthMs>("AuthMs");

builder.AddProject<Projects.LearningMs>("LearningMs");

builder.AddProject<Projects.ContentMs>("ContentMs");

builder.Build().Run();
