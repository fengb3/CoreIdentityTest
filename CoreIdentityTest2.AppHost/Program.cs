using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.WebApi>("WebApi");

var client = builder.AddProject<CoreIdentityTest2>("Client")
                    .WithReference(api)
	;

builder.Build().Run();