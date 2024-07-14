using System.Text.RegularExpressions;

public class Code11_4 {
    public static void Run() {
        var text = "Regexクラスを使った文字列操作について説明します。";
        bool isMatch = Regex.IsMatch(text, @"ます。$");
        if (isMatch)
            Console.WriteLine("'ます。'で終わっています");
        else
            Console.WriteLine("'ます。'で終わっていません");
    }

}