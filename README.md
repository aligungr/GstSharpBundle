# [GStreamer C# Bundle](https://github.com/aligungr/GstSharpBundle)

[![Nuget](https://img.shields.io/nuget/vpre/GstSharpBundle?label=GstSharpBundle)](https://www.nuget.org/packages/GstSharpBundle/)
[![Nuget](https://img.shields.io/nuget/vpre/GstSharpBundle?label=GstSharpBundle.Windows.x64)](https://www.nuget.org/packages/GstSharpBundle.Windows.x64/)

Cross platform GStreamer C# bindings library with all required binaries included.

## About

Original GStreamer C# bindings are available at [GstSharp](https://gitlab.freedesktop.org/gstreamer/gstreamer/-/tree/main/subprojects/gstreamer-sharp). This project is a variant of the original library with the following changes:
- .NET 8 and later is supported.
- NativeAOT and trimming are supported.
- All required binaries are included in the packages.
- No need to install GStreamer on the development or target environment.

## Installation and Usage

**Step 1:** Add the GStreamer C# Bundle NuGet package to your project:

```
Install-Package GstSharpBundle -Version VERSION_HERE
```

**Step 2:** Add runtime packages for your target platform. For example:

```
Install-Package GstSharpBundle.Windows.X64 -Version VERSION_HERE
```

(You can add more than one runtime package if you are targeting multiple platforms.)

**Step 3:** Call the initialization code in your main method:

```csharp
GStreamerBundle.Initialize();
```