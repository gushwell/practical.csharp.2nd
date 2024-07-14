using System.IO;
using System.Text;

public class Code10_48 {
    public static void Run() {
        var fullPath = Path.GetFullPath(@"../Greeting.txt");
        Console.WriteLine(fullPath);
    }
}

