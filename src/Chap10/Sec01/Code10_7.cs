using System.IO;
using System.Text;

public class Code10_7 {
    public static void Run() {
        var filePath = "./Sample.txt";
        var exists = File.ReadLines(filePath)
            .Where(s => !String.IsNullOrEmpty(s))
            .Any(s => s.All(c => Char.IsDigit(c)));

        Console.WriteLine(exists);
    }
}