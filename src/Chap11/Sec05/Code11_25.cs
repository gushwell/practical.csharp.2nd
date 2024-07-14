using System.Text.RegularExpressions;

public class Code11_25 {
    public static void Run() {
        var text = "しるし こもじ しんぶんし きもの トマト pops push pop";
        var pattern = @"\b(\w)\w\1\b";
        var matches = Regex.Matches(text, pattern);
        foreach (Match m in matches)
            Console.WriteLine($"'{m.Value}'");
    }
}