using System.IO;
using System.Text;

public class Code10_8 {
    public static void Run() {
        var filePath = "./Sample2.txt";
        var lines = File.ReadLines(filePath)
            .Distinct()
            .OrderBy(s => s.Length)
            .ToArray();
        foreach (var line in lines) {
            Console.WriteLine(line);
        }
    }
}