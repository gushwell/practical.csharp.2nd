using System.Globalization;

public class Code9_23 {
    public static void Run() {
        var today = DateTime.Today;
        // 当該月が何日あるかを求める
        int day = DateTime.DaysInMonth(today.Year, today.Month);
        // このdayを使って、DateTimeオブジェクトを生成する。endOfMonthが月末日
        var endOfMonth = new DateTime(today.Year, today.Month, day);
        Console.WriteLine(endOfMonth);
    }


}