public class Code9_8 {
    public static void Run() {
        if (DateTime.TryParse("平成28年3月15日", out var dt)) {
            Console.WriteLine(dt);
        }
    }
}