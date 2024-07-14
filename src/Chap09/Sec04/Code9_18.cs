using System.Globalization;

public class Code9_18 {
    public static void Run() {
        var now = DateTime.Now;
        var past = now - new TimeSpan(1, 30, 0); //- TimeSpanオブジェクトを引く
        Console.WriteLine(past);
    }
}