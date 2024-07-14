public class Code9_9 {
    public static void Run() {
        var date = new DateTime(2024, 4, 7, 21, 6, 47);
        var s1 = date.ToString("yyyy-MM-dd");                  // 2024-04-07
        var s2 = date.ToString("yyyy年M月d日(ddd)");            // 2024年4月7日(日)
        var s3 = date.ToString("yyyy年M月d日(dddd)");           // 2024年4月7日(日曜日)
        var s4 = date.ToString("yyyy年MM月dd日 HH時mm分ss秒");   // 2024年04月07日 21時06分47秒
        var s5 = date.ToString("tt hh:mm");                    // 午後 09:06
        var s6 = date.ToString("HH時mm分ss秒");                 // 21時06分47秒

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
        Console.WriteLine(s5);
        Console.WriteLine(s6);
    }
}