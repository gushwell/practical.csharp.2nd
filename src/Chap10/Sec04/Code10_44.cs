using System.IO;
using System.Text;

public class Code10_44 {
    public static void Run() {
        var di = new DirectoryInfo("./Example");
        var directories = di.EnumerateDirectories();
        foreach (var dir in directories) {
            Console.WriteLine($"{dir.FullName} {dir.CreationTime}");
        }

    }

    public static void Run2() {
        var di = new DirectoryInfo("./Example");
        var directories = di.EnumerateDirectories("*", SearchOption.AllDirectories)
                            .Where(d => d.Name.Length <= 5);
        foreach (var dir in directories) {
            Console.WriteLine($"{dir.FullName} {dir.CreationTime}");
        }
    }

}