var builder = DistributedApplication.CreateBuilder(args);

var keycloak = builder.AddKeycloak("keycloak", 8080)
    .WithDataVolume();

var mongo = builder.AddMongoDB("mongo");
var mongodb = mongo.AddDatabase("mongodb");

var apiService = builder.AddProject<Projects.AmbrDM_ApiService>("apiservice")
    .WithReference(keycloak)
    .WithReference(mongodb);

builder.AddProject<Projects.AmbrDM_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WithReference(keycloak);

builder.Build().Run();
