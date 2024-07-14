using System.IO;
using System.Text;

public class Code10_50 {
    public static void Run() {
        var topdir = "./Example/";
        var subdir = "Temp";
        var fname = "Greeting.txt";
        var path = Path.Combine(topdir, subdir, fname);
        Console.WriteLine(path);
    }
}

