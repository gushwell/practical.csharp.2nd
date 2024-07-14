using System.Globalization;

public class Code9_24 {
    public static void Run() {
        var today = DateTime.Today;
        int dayOfYear = today.DayOfYear;
        Console.WriteLine(dayOfYear);
    }

    public static void Bad() {
        var today = DateTime.Today;
        var baseDate = new DateTime(today.Year, 1, 1).AddDays(-1);
        TimeSpan ts = today - baseDate;
        Console.WriteLine(ts.Days);
    }
}