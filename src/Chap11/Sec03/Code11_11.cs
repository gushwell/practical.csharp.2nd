using System.Text.RegularExpressions;

public class Code11_11 {
    public static void Run() {
        var text = "C#には、《値型》と《参照型》の2つの型が存在します";
        var matches = Regex.Matches(text, @"《([^《》]+)》");
        foreach (Match match in matches) {
            Console.WriteLine($"<{match.Groups[1]}>");
        }
    }
}