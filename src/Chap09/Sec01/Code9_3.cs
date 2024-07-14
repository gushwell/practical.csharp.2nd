public class Code9_3 {
    public static void Run() {
        var now = DateTime.Now;
        int year = now.Year;                 // 年: Year
        int month = now.Month;               // 月: Month
        int day = now.Day;                   // 日: Day
        int hour = now.Hour;                 // 時: Hour
        int minute = now.Minute;             // 分: Minute
        int second = now.Second;             // 秒: Second
        int millisecond = now.Millisecond;   // 1/1000秒: Millisecond

        Console.WriteLine($"{now}");
        Console.WriteLine($"{year}/{month}/{day} {hour}:{minute}:{second} {millisecond}");
    }
}