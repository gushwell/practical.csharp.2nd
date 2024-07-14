using System.Text.RegularExpressions;

public class Code11_7 {
    public static void Run() {
        var text = "RegexクラスのMatchメソッドを使います";
        Match match = Regex.Match(text, @"\p{IsKatakana}+");
        if (match.Success)
            Console.WriteLine($"{match.Index}, {match.Value}");
    }


}