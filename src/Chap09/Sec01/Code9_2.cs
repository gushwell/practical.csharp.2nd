public class Code9_2 {
    public static void Run() {
        var today = DateTime.Today;
        var now = DateTime.Now;
        Console.WriteLine($"Today : {today}");
        Console.WriteLine($"Now : {now}");

        var utcNow = DateTime.UtcNow;
        Console.WriteLine($"UtcNow : {utcNow}");
    }
}