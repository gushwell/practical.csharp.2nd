using System.Globalization;

public class Code9_17 {
    public static void Run() {
        var now = DateTime.Now;
        var future = now + new TimeSpan(1, 30, 0); //- TimeSpanオブジェクトを加える
        Console.WriteLine(future);
    }
}