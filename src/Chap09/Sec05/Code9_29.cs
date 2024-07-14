using System.Globalization;

public class Code9_29 {
    public static void Run() {
        // 2016年9月の第3日曜日を得る
        DateTime day = DayOfNthWeek2(2016, 9, DayOfWeek.Sunday, 3);
        //Console.WriteLine(day);

        DateTime day1 = DayOfNthWeek2(2017, 1, DayOfWeek.Sunday, 5);
        //Console.WriteLine(day1);
        // 存在しない日の場合、例外が発生する
        // DateTime day2 = DayOfNthWeek(2017, 1, DayOfWeek.Wednesday, 5);
        // Console.WriteLine(day2);
    }

    static DateTime DayOfNthWeek2(int year, int month, DayOfWeek dayOfWeek, int nth) {
        // その月の1日が、何曜日かを求める。
        var firstDayOfWeek = (int)(new DateTime(year, month, 1)).DayOfWeek;
        // 求めたfirstDayOfWeekを使い、第1回目のX曜日が何日かを求める。
        var firstDay = 1 + ((int)dayOfWeek - firstDayOfWeek);
        // 0より小さい値ならば、7を加えることで、第1回目のX曜日が何日かがわかる。
        if (firstDay <= 0) {
            firstDay += 7;
        }
        // 第1X曜日の日にちに、7の倍数を加えることで、第n回目のX曜日が求まる。
        var day = firstDay + (nth - 1) * 7;
        return new DateTime(year, month, day);
    }
}