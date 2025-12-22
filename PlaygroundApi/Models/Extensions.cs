namespace PlaygroundApi.Models;

public static class Extensions
{
    extension(AboutResult)
    {
        public static AboutResult Create()
        {
            return new AboutResult(
                Application: "Playground API",
                Version: "1.0.0",
                Description: "This is a sample API for demonstration purposes.",
                DotnetVersion: System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription,
                OSVersion: OSVersionInfo.FromEnvironment(),
                []);
        }
    }

    extension(OSVersionInfo)
    {
        public static OSVersionInfo FromEnvironment()
        {
            return new OSVersionInfo(
                OSDescription: System.Runtime.InteropServices.RuntimeInformation.OSDescription,
                Platform: Environment.OSVersion.Platform.ToString(),
                Version: Environment.OSVersion.Version.ToString(),
                ServicePack: Environment.OSVersion.ServicePack,
                MajorVersion: Environment.OSVersion.Version.Major,
                MinorVersion: Environment.OSVersion.Version.Minor,
                BuildNumber: Environment.OSVersion.Version.Build,
                RevisionNumber: Environment.OSVersion.Version.Revision);
        }
    }
}
