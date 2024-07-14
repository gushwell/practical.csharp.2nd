using System.Text.RegularExpressions;

public class Code11_16 {
    public static void Run() {
        var text = "1234567890123456";
        var pattern = @"^(\d{4})(\d{4})(\d{4})(\d{4})$";
        var replaced = Regex.Replace(text, pattern, "$1-$2-$3-$4");
        Console.WriteLine(replaced);
    }
}