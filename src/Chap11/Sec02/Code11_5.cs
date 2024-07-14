using System.Text.RegularExpressions;

public class Code11_5 {
    public static void Run() {
        var strings = new[] { "Microsoft Windows", "windows", "Windows Server", "Windows", };
        var regex = new Regex(@"^(W|w)indows$");
        var count = strings.Count(s => regex.IsMatch(s));
        Console.WriteLine($"{count}行と一致");
    }

    public static void Bad() {
        var strings = new[] { "Microsoft Windows", "Windows Server", "Windows", };
        var regex = new Regex(@"(W|w)indows");
        var count = strings.Count(s => regex.IsMatch(s));
        Console.WriteLine($"{count}行と一致");
    }

}