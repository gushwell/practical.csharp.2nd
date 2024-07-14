using System.Globalization;

public class Code9_22 {
    public static void Run() {
        var dt1 = new DateTime(2016, 1, 20, 10, 0, 0);
        var dt2 = new DateTime(2016, 1, 21, 8, 0, 0);
        TimeSpan diff = dt2.Date - dt1.Date;
        Console.WriteLine($"{diff.Days}日間");
    }

    public static void Bad() {
        var dt1 = new DateTime(2016, 1, 20, 10, 0, 0);
        var dt2 = new DateTime(2016, 1, 21, 8, 0, 0);
        TimeSpan diff = dt2 - dt1;
        Console.WriteLine($"{diff.Days}日間");
    }
}