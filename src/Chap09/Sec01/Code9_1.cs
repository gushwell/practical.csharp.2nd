public class Code9_1 {
    public static void Run() {
        // 年月日を指定
        var dt1 = new DateTime(2016, 2, 15);
        // 年月日、時分秒を指定
        var dt2 = new DateTime(2016, 2, 15, 8, 45, 20);
        Console.WriteLine(dt1);
        Console.WriteLine(dt2);
    }
}