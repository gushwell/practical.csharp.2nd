using System.Reflection;

public class Code17_6 {
    public static void Run() {
        var path = GetMySelfPath();
        Console.WriteLine(path);
    }

    private static string GetMySelfPath() {
        var assembly = Assembly.GetExecutingAssembly();
        var locationUri = new System.Uri(assembly.Location);
        return locationUri.LocalPath;

    }

}
