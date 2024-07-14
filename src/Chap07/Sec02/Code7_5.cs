public static class Code7_5 {
    public static void Run() {
        List<int> numbers = new List<int>();
        for (int i = 0; i < 20; i++) {
            numbers.Add(-1);
        }
        foreach (int num in numbers)
            Console.Write($"{num} ");
        Console.WriteLine();
    }

}