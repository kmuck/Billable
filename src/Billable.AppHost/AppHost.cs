var builder = DistributedApplication.CreateBuilder(args);

// Configure PostgreSQL database
var postgres = builder.AddPostgres("postgres");

// Identity Database
var identityDb = postgres.AddDatabase("identity-db");

// JWT Secret
var jwtSecret = "super_secret_key_for_jwt_signing";

// Identity Service
var identityService = builder
    .AddProject<Projects.Billable_Services_Identity>("identity-service")
    .WithReference(identityDb)
    .WithEnvironment("Jwt__Key", jwtSecret);

// API Gateway
var apiGateway = builder
    .AddProject<Projects.Billable_ApiGateway>("api-gateway")
    .WithExternalHttpEndpoints()
    .WithReference(identityService);

// Build and run the application
builder.Build().Run();
