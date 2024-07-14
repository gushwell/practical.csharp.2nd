using System.Text.RegularExpressions;

public class Code11_15 {
    public static void Run() {
        var text = "1024バイト、8バイト文字、バイト、キロバイト";
        var pattern = @"(\d+)バイト";
        var replaced = Regex.Replace(text, pattern, "$1byte");
        Console.WriteLine(replaced);
    }
}