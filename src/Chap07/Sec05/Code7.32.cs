public static class Code7_32 {
    public static void Run() {
        var numbers = new List<int> { 9, 7, -5, -4, 2, 5, 4, 0, -4, 8, -1, 0, 4 };
        var index = numbers.FindIndex(n => n < 0);
        Console.WriteLine(index);
    }
}