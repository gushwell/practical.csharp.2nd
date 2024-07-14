using System.IO;
using System.Text;

public class Code10_3 {
    public static void Run() {
        var filePath = "./Greeting.txt";
        var lines = File.ReadLines(filePath);
        foreach (var line in lines) {
            Console.WriteLine(line);
        }
    }
}