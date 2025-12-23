var builder = DistributedApplication.CreateBuilder(args);

var playgroundApi = builder.AddProject<Projects.PlaygroundApi>("api")
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
    .WithUrlForEndpoint("https", _ => new ResourceUrlAnnotation
    {
        Url = "/about",
        DisplayText = "About",
    })
    .WithUrlForEndpoint("http", u => u.DisplayLocation = UrlDisplayLocation.DetailsOnly);

var frontend = builder.AddViteApp("frontend", "../frontend/react-playground")
    .WithReference(playgroundApi)
    .WaitFor(playgroundApi);

await builder.Build().RunAsync();
