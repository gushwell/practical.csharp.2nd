public class ListA_19 {
    public static void Run() {
        // 現地時刻を得る
        var now = DateTimeOffset.Now;
        Console.WriteLine($"Now = {now}");
        // UTC(協定世界時)に変換する
        var utc = now.ToUniversalTime();
        Console.WriteLine($"UTC = {utc}");
        // UTC(協定世界時)から現地時刻に変換する
        var localTime = utc.ToLocalTime();
        Console.WriteLine($"LocalTime = {localTime}");
    }
}
