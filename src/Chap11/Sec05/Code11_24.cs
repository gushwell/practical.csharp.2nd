using System.Text.RegularExpressions;

public class Code11_24 {
    public static void Run() {
        var text = "僕はパンのミミをちぎり、ペットのももに分け与えた";
        var pattern = @"(\w)\1";
        var matches = Regex.Matches(text, pattern);
        foreach (Match m in matches)
            Console.WriteLine($"'{m.Value}'");
    }
}