using PlaygroundApi.Helpers;

namespace PlaygroundApi.Services;

public interface IChordsService
{
    ScaleResult Major(string key);

    ScaleResult Dominant7(string key);

    ScaleResult Major7(string key);

    ScaleResult Minor(string key);
}

public class ChordsService : IChordsService
{
    public ScaleResult Major(string key)
    {
        return new ScaleResult
        {
            Notes = ScalesHelper.GetMajorChord(key)
        };
    }

    public ScaleResult Dominant7(string key)
    {
        return new ScaleResult
        {
            Notes = ScalesHelper.GetDominant7Chord(key)
        };
    }

    public ScaleResult Major7(string key)
    {
        return new ScaleResult
        {
            Notes = ScalesHelper.GetMajor7Chord(key)
        };
    }

    public ScaleResult Minor(string key)
    {
        return new ScaleResult
        {
            Notes = ScalesHelper.GetMinorChord(key)
        };
    }
}