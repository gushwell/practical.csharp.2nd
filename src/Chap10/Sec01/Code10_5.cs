using System.IO;
using System.Text;

public class Code10_5 {
    public static void Run() {
        var filePath = "./Sample.txt";
        var count = File.ReadLines(filePath)
                        .Count(s => s.Contains("C#"));
        Console.WriteLine(count);
    }
}