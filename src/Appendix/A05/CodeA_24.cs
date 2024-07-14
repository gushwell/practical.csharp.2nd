public class ListA_24 {
    public static void Run() {
        var utc = DateTimeOffset.UtcNow;
        var timezone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Singapore");
        // たとえば、上記のようなコードでTimeZoneInfoが取得されている
        //……
        var time = TimeZoneInfo.ConvertTime(utc, timezone);
        Console.WriteLine($"Asia/Singapore {time} {time.Offset}");
    }
}
