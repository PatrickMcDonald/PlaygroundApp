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

#pragma warning disable ASPIRECERTIFICATES001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
var frontend = builder.AddViteApp("frontend", "../frontend/react-playground")
    .WithHttpsEndpoint(env: "PORT")
    .WithHttpsDeveloperCertificate()
    .WithReference(playgroundApi)
    .WaitFor(playgroundApi);
#pragma warning restore ASPIRECERTIFICATES001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

await builder.Build().RunAsync();
