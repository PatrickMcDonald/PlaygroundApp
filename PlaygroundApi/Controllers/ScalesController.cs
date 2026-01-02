using PlaygroundApi.Services;

namespace PlaygroundApi.Controllers;

public class ScalesController(IScalesService scalesService) : ApiController<ScalesController>
{
    [HttpGet("{key}")]
    public Ok<ScaleResult> Get(string key)
    {
        var result = scalesService.Major(key);

        return TypedResults.Ok(result);
    }
}
