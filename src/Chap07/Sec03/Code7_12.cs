public static class Code7_12 {
    public static void Run() {
        List<int> numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
        int sum = 0;
        foreach (int n in numbers) {
            sum += n;
        }
        double average = (double)sum / numbers.Count;
        Console.WriteLine(average);
    }
}