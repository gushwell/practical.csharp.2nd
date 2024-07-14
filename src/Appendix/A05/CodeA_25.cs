public class ListA_25 {
    public static void Run() {
        var utc = DateTimeOffset.UtcNow;
        var time = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utc, "Asia/Singapore");
        Console.WriteLine($"Asia/Singapore {time} {time.Offset}");
    }
}
