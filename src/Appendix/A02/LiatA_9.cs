using System.Reflection;
using System.Diagnostics;
using System.Text.RegularExpressions;

public class ListA_9 {
    public static void Run() {
        var location = Assembly.GetEntryAssembly()!.Location!;
        var ver = FileVersionInfo.GetVersionInfo(location);
        var match = Regex.Match(ver.ProductVersion!, @"[\d+\.]+-([^+]+)\+?");
        var suffix = match.Groups[1].Value;
        Console.WriteLine(suffix);
    }
}