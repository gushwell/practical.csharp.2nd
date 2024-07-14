using System.Reflection;
using System.Diagnostics;

public class ListA_8 {
    public static void Run() {
        var assembly = Assembly.GetEntryAssembly()!;
        var informationalVersion = assembly
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
            .InformationalVersion;
        var version = informationalVersion!.Split('+')[0];
        Console.WriteLine(informationalVersion);
        Console.WriteLine(version);
    }
}