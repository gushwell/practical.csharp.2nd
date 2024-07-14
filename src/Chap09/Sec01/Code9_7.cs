public class Code9_7 {
    public static void Run() {
        if (DateTime.TryParse("2023/6/21", out var dt1)) {
            Console.WriteLine(dt1);
        }
        if (DateTime.TryParse("2023/6/21 10:41:38", out var dt2)) {
            Console.WriteLine(dt2);
        }
    }
}