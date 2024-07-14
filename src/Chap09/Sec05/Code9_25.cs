using System.Globalization;

public class Code9_25 {
    public static void Run() {
        Console.WriteLine(NextDay(DateTime.Now, DayOfWeek.Friday));
        Console.WriteLine(NextDay(DateTime.Now, DayOfWeek.Monday));
    }

    // Code 9-25
    private static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek) {
        var days = (int)dayOfWeek - (int)(date.DayOfWeek);
        if (days <= 0) {
            days += 7;
        }
        return date.AddDays(days);
    }
}