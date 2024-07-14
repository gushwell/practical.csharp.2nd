public static class Code6_18 {
    public static void Run() {
        var target = "   non-whitespace characters   ";
        var replaced = target.Trim();
        Console.WriteLine($"[{replaced}]");
    }

    public static void Bad() {
        var target = "   non-whitespace characters   ";
        target.Trim();
        Console.WriteLine($"[{target}]");
    }

    static void Other() {
        var target = "   non-whitespace characters   ";
        target = target.Trim();
        Console.WriteLine($"[{target}]");
    }
}