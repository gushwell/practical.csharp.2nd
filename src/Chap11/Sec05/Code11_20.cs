using System.Text.RegularExpressions;

public class Code11_20 {
    public static void Run() {
        var text = "<person><name>栗原利伸</name><age>22</age></person>";
        var pattern = @"<.+>";
        var matches = Regex.Matches(text, pattern);
        foreach (Match m in matches)
            Console.WriteLine($"'{m.Value}'");
    }
}