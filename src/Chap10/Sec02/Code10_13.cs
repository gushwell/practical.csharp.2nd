using System.IO;
using System.Text;

public class Code10_13 {
    public static void Run() {
        var names = new List<string> {
            "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
        };
        var filePath = "./Example/Cities.txt";
        File.WriteAllLines(filePath, names.Where(s => s.Length > 5));
        Utils.DisplayLines(filePath);
    }
}