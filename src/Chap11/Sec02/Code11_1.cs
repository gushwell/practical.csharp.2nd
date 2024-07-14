using System.Text.RegularExpressions;

public class Code11_1 {
    public static void Run() {
        var text = "private List<string> results = new List<string>();";
        bool isMatch = Regex.IsMatch(text, @"List<\w+>");
        if (isMatch)
            Console.WriteLine("見つかりました");
        else
            Console.WriteLine("見つかりません");

        var text2 = "<出井秀行>";
        bool isMatch2 = Regex.IsMatch(text2, @"<\w+>");
        Console.WriteLine(isMatch2);
    }

}