using System.Text.RegularExpressions;

public class Code11_18 {
    public static void Run() {
        var text = "a123456 b123 Z12345 AX98765";
        var pattern = @"\b[a-zA-Z][0-9]{5,}\b";
        var matches = Regex.Matches(text, pattern);
        foreach (Match m in matches)
            Console.WriteLine($"'{m.Value}'");
    }
}