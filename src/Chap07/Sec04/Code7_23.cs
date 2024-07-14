public static class Code7_23 {
    public static void Run() {
        var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
        bool isAllPositive = numbers.All(n => n > 0);
        Console.WriteLine(isAllPositive);
    }
}