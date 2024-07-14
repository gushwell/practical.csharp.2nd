using System.Text.RegularExpressions;

public class Code11_6 {
    public static void Run() {
        var strings = new[] { "13000", "-50.6", "0.123",  "+180.00",
                "10.2.5", "320-0851", " 123", "$1200", "500円", };
        var regex = new Regex(@"^[-+]?(\d+)(\.\d+)?$");
        foreach (var s in strings) {
            if (regex.IsMatch(s))
                Console.WriteLine(s);
        }
    }


}