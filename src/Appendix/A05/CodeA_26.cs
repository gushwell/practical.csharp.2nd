public class ListA_26 {
    public static void Run() {
        // ローカル時刻（日本の時刻）を得る
        var local = new DateTime(2024, 6, 11, 11, 20, 0);
        // DateTimeOffsetに変換する
        var date = new DateTimeOffset(local);
        // "America/New_York"の時刻に変換する
        var newYorkTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(date, "America/New_York");
        Console.WriteLine($"America/New_York {newYorkTime}");
        var singaporeTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(date, "Asia/Singapore");
        Console.WriteLine($"Asia/Singapore {singaporeTime}");

    }
}
