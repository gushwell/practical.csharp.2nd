public class ListA_27 {
    public static void Run() {
        var paristz = TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris");
        var parisTime = new DateTimeOffset(2024, 4, 6, 9, 0, 0, paristz.BaseUtcOffset);
        // 変数chinaTimeに北京の時刻(DateTimeOffset)が入っている
        // この時刻を"Pacific/Honolulu"の時刻に変換する
        var honoluluTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(parisTime, "Pacific/Honolulu");
        Console.WriteLine($"Paris {parisTime}");
        Console.WriteLine($"Honolulu {honoluluTime}");
    }
}
