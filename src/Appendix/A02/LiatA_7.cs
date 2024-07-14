using System.Reflection;
using System.Diagnostics;
using System.Text.RegularExpressions;

public class ListA_7 {
    public static void Run() {
        var location = Assembly.GetEntryAssembly()!.Location!;
        var ver = FileVersionInfo.GetVersionInfo(location);
        var version = ver.ProductVersion!.Split('+')[0];
        Console.WriteLine(ver.ProductVersion);
        Console.WriteLine(version);
    }
}