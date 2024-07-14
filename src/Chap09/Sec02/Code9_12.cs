using System.Globalization;

public class Code9_12 {
    public static void Run() {
        var date = new DateTime(2023, 8, 15);
        var culture = new CultureInfo("ja-JP");
        culture.DateTimeFormat.Calendar = new JapaneseCalendar();
        var str = date.ToString("ggyy年M月d日", culture);
        Console.WriteLine(str);

        // gg が元号
        var str2 = date.ToString("gg", culture);
        Console.WriteLine(str2);
        
    }
}