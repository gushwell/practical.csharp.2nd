public static class Code7_13 {
    public static void Run() {
        var numbers = new List<int> { 9, 7, -5, 4, 2, 5, 4, 2, -4, 8, -1, 6, 4 };
        // 0より大きな値が入っていることを前提にしている
        var min = numbers.Where(n => n > 0)
                         .Min();
        Console.WriteLine(min);
    }
}