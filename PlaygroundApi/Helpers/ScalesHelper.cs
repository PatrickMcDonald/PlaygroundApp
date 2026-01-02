namespace PlaygroundApi.Helpers;

public static class ScalesHelper
{
    //private static readonly string[] Notes = ["C", "D♭", "D", "E♭", "E", "F", "G♭", "G", "A♭", "A", "B♭", "B"];
    private static readonly string[] Notes = ["C", "C♯", "D", "D♯", "E", "F", "F♯", "G", "G♯", "A", "A♯", "B"];

    private static readonly int[] MajorScaleIntervals = [2, 2, 1, 2, 2, 2, 1];

    private static readonly int[] MajorTriadIntervals = [4, 3];
    private static readonly int[] Dominant7Intervals = [4, 3, 3];
    private static readonly int[] Major7Intervals = [4, 3, 4];
    private static readonly int[] MinorTriadIntervals = [3, 4];

    public static string[] GetMajorScale(string key)
    {
        return [.. GetScale(key, MajorScaleIntervals)];
    }

    public static string[] GetMajorChord(string key)
    {
        return [.. GetScale(key, MajorTriadIntervals)];
    }

    public static string[] GetDominant7Chord(string key)
    {
        return [.. GetScale(key, Dominant7Intervals)];
    }

    public static string[] GetMajor7Chord(string key)
    {
        return [.. GetScale(key, Major7Intervals)];
    }

    public static string[] GetMinorChord(string key)
    {
        return [.. GetScale(key, MinorTriadIntervals)];
    }

    public static IEnumerable<string> GetScale(string key, int[] intervals)
    {
        int startIndex = Array.IndexOf(Notes, key);
        if (startIndex == -1) throw new ArgumentException("Invalid key.");

        yield return Notes[startIndex];

        foreach (var interval in intervals)
        {
            startIndex = (startIndex + interval) % Notes.Length;
            yield return Notes[startIndex];
        }
    }
}
