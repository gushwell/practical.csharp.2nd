public static class Code7_6 {
    public static void Run() {
        var array = Enumerable
            .Range(1, 20)
            .ToArray();
        foreach (var num in array)
            Console.Write($"{num} ");
        Console.WriteLine();
    }

}