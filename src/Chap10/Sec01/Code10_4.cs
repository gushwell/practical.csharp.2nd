using System.IO;
using System.Text;

public class Code10_4 {
    public static void Run() {
        var filePath = "./Sample.txt";
        var lines = File.ReadLines(filePath)
                        .Take(10)
                        .ToArray();
        foreach (var line in lines) {
            Console.WriteLine(line);
        }
    }
}