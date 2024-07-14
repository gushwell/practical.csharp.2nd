using System.Globalization;

public class Code9_19 {
    public static void Run() {
        var today = DateTime.Today;
        var future = today.AddDays(20);
        var past = today.AddDays(-20);
        Console.WriteLine(future);
        Console.WriteLine(past);
    }
}