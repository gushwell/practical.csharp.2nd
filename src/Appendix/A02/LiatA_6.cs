using System.Reflection;
using System.Diagnostics;

public class ListA_6 {
    public static void Run() {
        var location = Assembly.GetEntryAssembly()!.Location!;
        var ver = FileVersionInfo.GetVersionInfo(location);
        Console.WriteLine("{0}.{1}.{2}",
                          ver.ProductMajorPart, ver.ProductMinorPart,
                          ver.ProductBuildPart);
    }
}