public static class Code7_33 {
    public static void Run() {
        var numbers = new List<int> { 9, 7, -5, -4, 2, 5, 4, 0, -4, 8, -1, 0, 4 };
        var results = numbers
            .Where(n => n > 0)
            .Take(5);
        foreach (var item in results) {
            Console.WriteLine(item);
        }
    }
}