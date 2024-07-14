using System.IO;
using System.Text;

public class Code10_51 {
    public static void Run() {
        var tempFileName = Path.GetTempFileName();
        Console.WriteLine(tempFileName);
    }
}