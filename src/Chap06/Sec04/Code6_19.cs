public static class Code6_19 {
    public static void Run() {
        var target = "   non-whitespace characters   ";
        var replaced1 = target.TrimStart();
        var replaced2 = target.TrimEnd();
        Console.WriteLine($"[{replaced1}]\n[{replaced2}]");
    }

}