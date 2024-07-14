public class Code9_4 {
    public static void Run() {
        var today = DateTime.Today;
        DayOfWeek dayOfWeek = today.DayOfWeek;
        if (dayOfWeek == DayOfWeek.Sunday) {
            Console.WriteLine("今日は日曜日です");
        } else {
            Console.WriteLine("今日は日曜日ではありません");
        }
    }
}