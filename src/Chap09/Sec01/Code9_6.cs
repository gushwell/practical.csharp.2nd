public class Code9_6 {
    public static void Run() {
        var isLeapYear = DateTime.IsLeapYear(2024);
        if (isLeapYear) {
            Console.WriteLine("閏年です");
        } else {
            Console.WriteLine("閏年ではありません");
        }
    }
}