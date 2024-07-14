public class ListA_23 {
    public static void Run() {
        // タイムゾーンのId一覧を得る。
        var timeZones = TimeZoneInfo.GetSystemTimeZones();
        foreach (var timezone in timeZones)
            Console.WriteLine($"'{timezone.Id}' - '{timezone.DisplayName}'");
    }
}