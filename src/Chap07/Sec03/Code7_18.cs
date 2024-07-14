public static class Code7_18 {
    public static void Run() {
        List<int> numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
        int count = 0;
        foreach (int n in numbers) {
            if (n == 0) {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}