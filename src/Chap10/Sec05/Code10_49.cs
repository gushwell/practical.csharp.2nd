using System.IO;
using System.Text;

public class Code10_49 {
    public static void Run() {
        var dir = "./Example/Temp";
        var fname = "Greeting.txt";
        var path = Path.Combine(dir, fname);
        Console.WriteLine(path);
    }

    public static void Bad() {
        var dir = "./Example/Temp";
        var fname = "Greeting.txt";
        var path = dir + "/" + fname;
        Console.WriteLine(path);
    }
}

