using System.Text.RegularExpressions;

public class Code11_10 {
    public static void Run() {
        var text = "private List<string> results = new List<string>();";
        var matches = Regex
            .Matches(text, @"\b[a-z]+\b")
            .Cast<Match>()
            .OrderBy(x => x.Length);
        foreach (Match match in matches) {
            Console.WriteLine($"Index={match.Index}, Length={match.Length}, Value={match.Value}");
        }
    }
}