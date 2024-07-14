using Chap08;

public static class Code8_13 {
    public static void Run() {
        var dict = new Dictionary<MonthDay, string> {
            { new MonthDay(3, 5), "珊瑚の日" },
            { new MonthDay(8, 4), "箸の日" },
            { new MonthDay(10, 3), "登山の日" },
        };
        var md = new MonthDay(8, 4);
        var s = dict[md];
        Console.WriteLine(s);
    }
}
