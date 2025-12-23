namespace PlaygroundApi.Models;

public record OSVersionInfo(
    string OSDescription,
    string Platform,
    string Version,
    string ServicePack,
    string ProcessArchitecture);
