using System.IO;
using System.Text;

public class Code10_2 {
    public static void Run() {
        var filePath = "./Greeting.txt";
        var lines = File.ReadAllLines(filePath, Encoding.UTF8);
        foreach (var line in lines) {
            Console.WriteLine(line);
        }
    }
}