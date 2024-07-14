using System.IO;
using System.Text;

public class Code10_43 {
    public static void Run() {
        var di = new DirectoryInfo("./Example");
        var files = di.EnumerateFiles("*");
        foreach (var file in files) {
            Console.WriteLine($"{file.Name} {file.CreationTime}");
        }
    }

    public static void Run2() {
        var di = new DirectoryInfo("./Example/temp");
        var files = di.EnumerateFiles("*.txt")
              .Where(x => x.Name.Contains("test"))
              .Take(20);
        foreach (var file in files) {
            Console.WriteLine($"{file.Name} {file.CreationTime}");
        }
    }

    public static void Run3() {
        var di = new DirectoryInfo("./Example");
        var files = di.EnumerateFiles("*", SearchOption.AllDirectories);
        foreach (var file in files) {
            Console.WriteLine($"{file.Name} {file.CreationTime}");
        }
    }
}