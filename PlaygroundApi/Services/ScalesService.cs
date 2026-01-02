using PlaygroundApi.Helpers;

namespace PlaygroundApi.Services;

public interface IScalesService
{
    ScaleResult Major(string key);
}

public class ScalesService : IScalesService
{
    public ScaleResult Major(string key)
    {
        // Implement your logic to get the major scale for the given key
        return new ScaleResult
        {
            Notes = ScalesHelper.GetMajorScale(key)
        };
    }
}
