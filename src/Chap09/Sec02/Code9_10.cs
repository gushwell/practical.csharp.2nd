public class Code9_10 {
    // コメントは、Windowsでの結果を示している
    public static void Run() {
        var date = new DateTime(2024, 4, 7, 21, 6, 47);
        var s1 = date.ToString("d");  // 短い形式の日付：2024/04/07
        var s2 = date.ToString("D");  // 長い形式の日付：2024年4月7日
        var s3 = date.ToString("f");  // 完全な日付と短い形式の時刻：2024年4月7日 21:06
        var s4 = date.ToString("F");  // 完全な日付と長い形式の時刻：2024年4月7日 21:06:47
        var s5 = date.ToString("t");  // 短い形式の時刻：21:06
        var s6 = date.ToString("T");  // 長い形式の時刻：21:06:47

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
        Console.WriteLine(s5);
        Console.WriteLine(s6);
    }
}