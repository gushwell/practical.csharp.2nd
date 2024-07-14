using System.Text.RegularExpressions;

public class Code11_13 {
    public static void Run() {
        var text = "Word, Excel ,PowerPoint , Outlook,OneDrive";
        var pattern = @"\s*,\s*";
        var replaced = Regex.Replace(text, pattern, ", ");
        Console.WriteLine(replaced);
    }
}