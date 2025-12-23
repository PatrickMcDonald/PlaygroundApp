namespace PlaygroundApi.Models;

public record AboutResult(
    string Environment,
    string Application,
    string Version,
    string DotnetVersion,
    TimeSpan ProcessUptime,
    OSVersionInfo OSVersion,
    OrderedDictionary<string, object?> Services);
