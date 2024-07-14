public class Code16_38 {
    public static void Run() {
        var season = GetCalendarSeason(new DateTime(2024, 3, 18));
        Console.WriteLine(season);

    }

    // Monthは、1-12までが保証されているので、12 or 1 or 2 のところは _ でも良い。
    static string GetCalendarSeason(DateTime date) =>
        date.Month switch {
            3 or 4 or 5 => "春",
            6 or 7 or 8 => "夏",
            9 or 10 or 11 => "秋",
            12 or 1 or 2 => "冬",
        };
}