using System.IO;
using System.Text;

public class Code10_9 {
    public static void Run() {
        var filePath = "./Code10_9.cs";
        var lines = File.ReadLines(filePath)
            .Select((s, ix) => $"{ix + 1,4}: {s}");
        foreach (var line in lines) {
            Console.WriteLine(line);
        }
    }
}