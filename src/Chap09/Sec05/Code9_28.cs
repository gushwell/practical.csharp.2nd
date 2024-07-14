using System.Globalization;

public class Code9_28 {
    public static void Run() {
        // 2024年9月の第3日曜日を得る
        DateTime day = DayOfNthWeek(2024, 9, DayOfWeek.Sunday, 3);
        Console.WriteLine(day);
        
        // 存在しない日の場合、例外が発生する
        // DateTime day2 = DayOfNthWeek(2017, 1, DayOfWeek.Wednesday, 5);
        // Console.WriteLine(day2);
    }

    // Code 9-28
    static DateTime DayOfNthWeek(int year, int month, DayOfWeek dayOfWeek, int nth) {
        // LINQを使い第1回目のX曜日が何日かを求める。
        var firstDay = Enumerable.Range(1, 7)
                                 .Select(d => new DateTime(year, month, d))
                                 .First(d => d.DayOfWeek == dayOfWeek)
                                 .Day;
        // 第1X曜日の日にちに、7の倍数を加えることで、第n回目のX曜日が求まる。
        var day = firstDay + (nth - 1) * 7;
        return new DateTime(year, month, day);
    }
}