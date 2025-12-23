namespace PlaygroundApi.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class AboutController(IHostEnvironment env) : ApiController<AboutController>
{
    [HttpGet]
    public Ok<AboutResult> Get()
    {
        return TypedResults.Ok(AboutResult.Create(env));
    }
}
