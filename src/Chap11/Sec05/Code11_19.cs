using System.Text.RegularExpressions;

public class Code11_19 {
    public static void Run() {
        var text = "シーズン、ゴールド、シーソー、ゴールデンなどと一致します。スウェーデンやノートなどとは一致しません。";
        var pattern = @"(\b|[^\p{IsKatakana}])(\p{IsKatakana}ー\p{IsKatakana}{2,3})(\b|[^\p{IsKatakana}])";
        var matches = Regex.Matches(text, pattern);
        foreach (Match m in matches)
            Console.WriteLine($"'{m.Groups[2]}'");
    }
}