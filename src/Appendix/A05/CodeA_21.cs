public class ListA_21 {
    public static void Run() {
        if (DateTimeOffset.TryParse("2024/03/26 1:07:21 +09:00", out var time)) {
            Console.WriteLine($"{time} | {time.ToUniversalTime()}");
        }
    }
}
