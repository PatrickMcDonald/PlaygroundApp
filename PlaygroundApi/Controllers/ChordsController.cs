namespace PlaygroundApi.Controllers;

public class ChordsController(IChordsService chordsService) : ApiController<ChordsController>
{
    [HttpGet("{key}/Major")]
    public Ok<ScaleResult> GetMajor(string key)
    {
        var result = chordsService.Major(key);
        return TypedResults.Ok(result);
    }

    [HttpGet("{key}/7")]
    public Ok<ScaleResult> GetDominant7(string key)
    {
        var result = chordsService.Dominant7(key);
        return TypedResults.Ok(result);
    }

    [HttpGet("{key}/maj7")]
    public Ok<ScaleResult> GetMajor7(string key)
    {
        var result = chordsService.Major7(key);
        return TypedResults.Ok(result);
    }

    [HttpGet("{key}/Minor")]
    public Ok<ScaleResult> GetMinor(string key)
    {
        var result = chordsService.Minor(key);
        return TypedResults.Ok(result);
    }
}
