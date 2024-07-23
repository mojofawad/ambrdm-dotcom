var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AmbrDM_ApiService>("apiservice");

builder.AddProject<Projects.AmbrDM_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
