using System.IO;
using System.Text;

public class Utils {
    public static void DisplayLines(string filePath) {
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines) {
            Console.WriteLine(line);
        }
    }

}