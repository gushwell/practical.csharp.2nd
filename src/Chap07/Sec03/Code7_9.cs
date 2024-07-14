public static class Code7_9 {
    public static void Run() {
        var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
        var average = numbers.Average();
        Console.WriteLine(average);
    }
}