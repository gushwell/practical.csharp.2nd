using System.Globalization;

public class Code9_14 {
    public static void Run() {
        var date = new DateTime(1998, 6, 25);
        var culture = new CultureInfo("ja-JP");
        culture.DateTimeFormat.Calendar = new JapaneseCalendar();
        
        var dayOfWeek = culture.DateTimeFormat.GetDayName(date.DayOfWeek);
        Console.WriteLine(dayOfWeek);

        var shortDayOfWeek = culture.DateTimeFormat.GetShortestDayName(date.DayOfWeek);
        Console.WriteLine(shortDayOfWeek);

        // ‚¨‚Ü‚¯
        // ddd‚Í—j“ú
        Console.WriteLine(date.ToString("ddd", culture));
    }
}