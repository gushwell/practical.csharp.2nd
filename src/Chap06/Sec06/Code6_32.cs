public static class Code6_32 {
    public static void Run() {
        var str = "C#プログラミング";
        foreach (var c in str)
            Console.Write($"[{c}]");
        Console.WriteLine();
    }
}