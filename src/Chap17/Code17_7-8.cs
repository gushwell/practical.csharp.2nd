using System.Runtime.CompilerServices;
using System.Text;
using System.Reflection;

public class List17_7_8 {
    public static void Code17_7() {
        var year = 2024;
        var month = 4;
        var dayOfWeek = DayOfWeek.Sunday;
        var firstDay = Enumerable.Range(1, 7)
            .Select(d => new DateTime(year, month, d))
            .First(d => d.DayOfWeek == dayOfWeek);

        Console.WriteLine(firstDay);
    }

    public static void Code17_8() {
        var year = 2024;
        var month = 4;
        var dayOfWeek = DayOfWeek.Sunday;
        var firstDay = Enumerable.Range(1, 7)
            .Select(d => new DateTime(year, month, d))
            .First(d => d.DayOfWeek == dayOfWeek);
        Console.WriteLine(firstDay);
    }
}
