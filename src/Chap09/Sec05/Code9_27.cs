using System.Globalization;

public class Code9_27 {
    public static void Run() {
        var date = DateTime.Today;
        var nth = NthWeek(date);
        Console.WriteLine($"第{nth}週");
    }

    // Code 9-27
    static int NthWeek(DateTime date) {
        var firstDay = new DateTime(date.Year, date.Month, 1);
        var firstDayOfWeek = (int)(firstDay.DayOfWeek);
        return (date.Day + firstDayOfWeek - 1) / 7 + 1;
    }

}