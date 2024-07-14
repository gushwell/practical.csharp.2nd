using System.Text.RegularExpressions;

public class Code11_9 {
    public static void Run() {
        var text = "private List<string> results = new List<string>();";
        Match match = Regex.Match(text, @"List<\w+>");
        while (match.Success) {
            Console.WriteLine($"Index={match.Index}, Length={match.Length}, Value={match.Value}");
            match = match.NextMatch();
        }
    }
}