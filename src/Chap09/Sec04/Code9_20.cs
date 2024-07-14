using System.Globalization;

public class Code9_20 {
    public static void Run() {
        var date = new DateTime(2021, 10, 5);
        var future = date.AddYears(2).AddMonths(5);
        Console.WriteLine(future);
    }
}