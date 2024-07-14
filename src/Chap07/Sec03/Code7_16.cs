public static class Code7_16 {
    public static void Run() {
        var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
        var count = numbers.Count(n => n == 0);
        Console.WriteLine(count);
    }

    public static void Bad() {
        var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
        var count = numbers
            .Where(n => n == 0)
            .Count();
        Console.WriteLine(count);
    }
}