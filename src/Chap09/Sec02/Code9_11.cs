public class Code9_11 {
    public static void Run() {
        var today = DateTime.Today;
        var str = $"{today.Year}年{today.Month,2}月{today.Day,2}日";
        Console.WriteLine(str);
    }
}