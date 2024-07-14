using System.Text.RegularExpressions;

public class Code11_12 {
    public static void Run() {
        var text = "C#の学習をすこしずつ進めていこう。";
        var pattern = @"少しづつ|すこしづつ|すこしずつ";
        var replaced = Regex.Replace(text, pattern, "少しずつ");
        Console.WriteLine(replaced);
    }
}