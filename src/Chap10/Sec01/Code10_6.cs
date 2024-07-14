using System.IO;
using System.Text;

public class Code10_6 {
    public static void Run() {
        var filePath = "./Sample.txt";
        var lines = File.ReadLines(filePath)
            .Where(s => !String.IsNullOrWhiteSpace(s))
            .ToArray();
        foreach (var line in lines) {
            Console.WriteLine(line);
        }
    }
}