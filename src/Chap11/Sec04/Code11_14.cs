using System.Text.RegularExpressions;

public class Code11_14 {
    public static void Run() {
        var text = "foo.htm bar.html baz.htm";
        var pattern = @"\.(htm)\b";
        var replaced = Regex.Replace(text, pattern, ".html");
        Console.WriteLine(replaced);
    }
}