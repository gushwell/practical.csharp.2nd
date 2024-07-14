public class ListA_22 {
    public static void Run() {
        TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        //TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("America/Los_Angeles");
        //TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById("Asia/Tokyo");
        Console.WriteLine($"Utc との差      {tz.BaseUtcOffset}");
        Console.WriteLine($"タイムゾーンID  {tz.Id}");
        Console.WriteLine($"表示名          {tz.DisplayName}");
        Console.WriteLine($"標準時の表示名  {tz.StandardName}");
        Console.WriteLine($"夏時間の表示名  {tz.DaylightName}");
        Console.WriteLine($"夏時間の有無    {tz.SupportsDaylightSavingTime}");

    }
}
