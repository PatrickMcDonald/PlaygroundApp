var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PlaygroundApi>("api")
    .WithUrlForEndpoint("https", u => u.DisplayLocation = UrlDisplayLocation.DetailsOnly)
    .WithUrlForEndpoint("https", _ => new ResourceUrlAnnotation
    {
        Url = "/scalar/v1",
        DisplayText = "Scalar",
    })
    .WithUrlForEndpoint("https", _ => new ResourceUrlAnnotation
    {
        Url = "/api-docs",
        DisplayText = "Redoc",
    })
    .WithUrlForEndpoint("http", u => u.DisplayLocation = UrlDisplayLocation.DetailsOnly);

await builder.Build().RunAsync();
