using System;
using System.IO;
using System.Runtime.InteropServices;

namespace GstSharpBundle;

public static class GStreamerBundle
{
    private static bool _initialized;

    public static void Initialize()
    {
        lock (typeof(GStreamerBundle))
        {
            if (_initialized) return;
            _initialized = true;

            var binDirectory = Path.Combine("gstreamer", MakeRuntimeIdentifier(), "bin");

            AddAdditionalDllDirectory(binDirectory);
        }
    }

    private static string MakeRuntimeIdentifier()
    {
        var architecture = RuntimeInformation.ProcessArchitecture;

        if (OperatingSystem.IsWindows())
        {
            switch (architecture)
            {
                case Architecture.X86:
                    return "win-x86";
                case Architecture.X64:
                    return "win-x64";
                case Architecture.Arm64:
                    return "win-arm64";
            }
        }

        if (OperatingSystem.IsLinux())
        {
            switch (architecture)
            {
                case Architecture.X86:
                    return "linux-x86";
                case Architecture.X64:
                    return "linux-x64";
                case Architecture.Arm:
                    return "linux-arm";
                case Architecture.Arm64:
                    return "linux-arm64";
            }
        }

        if (OperatingSystem.IsMacOS())
        {
            switch (architecture)
            {
                case Architecture.X64:
                    return "osx-x64";
                case Architecture.Arm64:
                    return "osx-arm64";
            }
        }

        if (OperatingSystem.IsIOS())
        {
            switch (architecture)
            {
                case Architecture.Arm64:
                    return "ios-arm64";
            }
        }
        

        if (OperatingSystem.IsAndroid())
        {
            switch (architecture)
            {
                case Architecture.Arm64:
                    return "android-arm64";
            }
        }
        
        throw new PlatformNotSupportedException();
    }

    private static void AddAdditionalDllDirectory(string path)
    {
        var oldValue = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Process);
        var newValue = Path.GetFullPath(path) + Path.PathSeparator + oldValue;
        Environment.SetEnvironmentVariable("PATH", newValue, EnvironmentVariableTarget.Process);
    }

    internal static bool DynamicLoadingSupported => false;
}