public static class Code7_42 {
    public static void Run() {
        var numbers = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24 };
        var results = numbers.Distinct();
        results.ToList().ForEach(Console.WriteLine);
    }
}