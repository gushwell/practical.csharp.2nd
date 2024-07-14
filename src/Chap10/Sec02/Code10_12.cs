using System.IO;
using System.Text;

public class Code10_12 {
    public static void Run() {
        var lines = new[] { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", };
        var filePath = "./Example/Cities.txt";
        File.WriteAllLines(filePath, lines);
        Utils.DisplayLines(filePath);
    }

}