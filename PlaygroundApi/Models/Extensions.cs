namespace PlaygroundApi.Models;

public static class Extensions
{
    extension(AboutResult)
    {
        public static AboutResult Create(IHostEnvironment env)
        {
            return new AboutResult(
                Environment: env.EnvironmentName,
                Application: env.ApplicationName,
                Version: System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "",
                DotnetVersion: System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription,
                ProcessUptime: TimeSpan.FromMilliseconds(Environment.TickCount64),
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
                ProcessArchitecture: System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString());
        }
    }
}
