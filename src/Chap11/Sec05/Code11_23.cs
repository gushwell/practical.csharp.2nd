using System.Text.RegularExpressions;

public class Code11_23 {
    public static void Run() {
        var text = "<p>あいうえお</p><p>かきくけこ</p>";
        var pattern = @"<p>(.*?)</p>";
        var matches = Regex.Matches(text, pattern);
        foreach (Match m in matches)
            Console.WriteLine($"'{m.Groups[1].Value}'");
    }
}