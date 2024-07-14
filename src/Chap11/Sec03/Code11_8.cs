using System.Text.RegularExpressions;

public class Code11_8 {
    public static void Run() {
        var text = "private List<string> results = new List<string>();";
        var matches = Regex.Matches(text, @"List<\w+>");
        foreach (Match match in matches) {
            Console.WriteLine($"Index={match.Index}, Length={match.Length}, Value={match.Value}");
        }
    }
}