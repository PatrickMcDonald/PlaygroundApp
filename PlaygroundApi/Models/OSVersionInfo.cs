namespace PlaygroundApi.Models;

public record OSVersionInfo(
    string OSDescription,
    string Platform,
    string Version,
    string ServicePack,
    int MajorVersion,
    int MinorVersion,
    int BuildNumber,
    int RevisionNumber);
