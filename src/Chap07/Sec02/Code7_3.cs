public static class Code7_3 {
    public static void Run() {
        var strings = Enumerable
            .Repeat("(unknown)", 12) //- "(unknown)"で埋める
            .ToArray();
        foreach (var s in strings)
            Console.Write($"{s} ");
        Console.WriteLine();

    }

}