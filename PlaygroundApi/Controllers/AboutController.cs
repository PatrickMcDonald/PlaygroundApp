namespace PlaygroundApi.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
[ApiController]
[Route("about")]
public class AboutController : ControllerBase
{
    [HttpGet]
    public Ok<AboutResult> Get()
    {
        return TypedResults.Ok(AboutResult.Create());
    }
}
