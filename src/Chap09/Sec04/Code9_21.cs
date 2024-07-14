using System.Globalization;

public class Code9_21 {
    public static void Run() {
        var date1 = new DateTime(2009, 10, 22, 1, 30, 20);
        var date2 = new DateTime(2009, 10, 22, 2, 40, 56);
        TimeSpan diff = date2 - date1;
        Console.WriteLine($"差は、{diff.Days}日間{diff.Hours}時間{diff.Minutes}分{diff.Seconds}秒です");
        Console.WriteLine($"トータルで{diff.TotalSeconds}秒です");
    }
}