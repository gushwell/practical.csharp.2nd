using System.Text.RegularExpressions;

public class Code11_2 {
    public static void Run() {
        var text = "private List<string> results = new List<string>();";
        var regex = new Regex(@"List<\w+>");
        bool isMatch = regex.IsMatch(text);
        if (isMatch)
            Console.WriteLine("見つかりました");
        else
            Console.WriteLine("見つかりません");
    }

}