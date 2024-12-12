var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MvcSchool>("mvcschool");

builder.Build().Run();
