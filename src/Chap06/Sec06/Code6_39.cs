public static class Code6_39 {
    public static void Run() {
        var article = 12;
        var clause = 5;
        var header = $"第{article,2}条{clause,2}項";
        Console.WriteLine(header);
    }
}