public static class Code7_37 {
    public static void Run() {
        var numbers = new List<int> { 9, 7, 5, 4, 2, 4, 0, -4, 7, 0, 4 };
        var selected = numbers.SkipWhile(n => n >= 0)
                              .ToList();
        selected.ForEach(Console.WriteLine);
    }
}