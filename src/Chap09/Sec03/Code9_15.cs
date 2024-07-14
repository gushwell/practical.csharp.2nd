using System.Globalization;

public class Code9_15 {
    public static void Run() {
        var dt1 = new DateTime(2006, 10, 18, 1, 30, 21);
        var dt2 = new DateTime(2006, 11, 2, 18, 5, 28);
        if (dt1 < dt2) {
            Console.WriteLine("dt2の方が新しい日時です");
        } else if (dt1 == dt2) {
            Console.WriteLine("dt1とdt2は同じ日時です");
        }
    }
}