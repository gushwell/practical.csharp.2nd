using System.Text.RegularExpressions;

public class Code11_17 {
    public static void Run() {
        var text = "Word, Excel ,PowerPoint , Outlook,OneDrive";
        var pattern = @"\s*,\s*";

        string[] substrings = Regex.Split(text, pattern);
        foreach (var match in substrings) {
            Console.WriteLine($"'{match}'");
        }
    }
}