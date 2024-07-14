using System.Text.RegularExpressions;

public class Code11_3 {
    public static void Run() {
        var text = "using System.Text.RegularExpressions;";
        bool isMatch = Regex.IsMatch(text, @"^using");
        if (isMatch)
            Console.WriteLine("'using'で始まっています");
        else
            Console.WriteLine("'using'で始まっていません");
    }

}