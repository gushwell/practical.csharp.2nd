public static class Code7_2 {
    public static void Run() {
        var numbers = Enumerable
            .Repeat(-1, 20)             //- -1で埋める
            .ToList();                  //- List<int>に変換
        foreach (var num in numbers)
            Console.Write($"{num} ");
        Console.WriteLine();

    }

}