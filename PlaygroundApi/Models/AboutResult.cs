namespace PlaygroundApi.Models;

public record AboutResult(
    string Application,
    string Version,
    string Description,
    string DotnetVersion,
    OSVersionInfo OSVersion,
    OrderedDictionary<string, object?> Services);
