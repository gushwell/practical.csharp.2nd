using System.Globalization;

public class Code9_16 {
    public static void Run() {
        var dt1 = new DateTime(2001, 10, 25, 1, 30, 21);
        var dt2 = new DateTime(2001, 10, 25, 18, 5, 28);
        if (dt1.Date < dt2.Date) {
            Console.WriteLine("dt2の方が新しい日にちです");
        } else if (dt1.Date == dt2.Date) {
            Console.WriteLine("dt1とdt2は、同じ日にちです");
        }
    }
}