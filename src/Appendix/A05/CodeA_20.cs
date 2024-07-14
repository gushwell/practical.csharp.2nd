public class ListA_20 {
    public static void Run() {
        // 現地時刻を得る
        var now = DateTimeOffset.Now;
        // UTC(協定世界時)に変換する
        var utc = now.ToUniversalTime();
        // 現在の時刻と、そこから変換したUTCを比較する
        if (now == utc)
            Console.WriteLine($"'{now}' == '{utc}'");
        else
            Console.WriteLine($"'{now}' != '{utc}'");
    }
}
