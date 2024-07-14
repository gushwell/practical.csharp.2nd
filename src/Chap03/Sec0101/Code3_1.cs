static class Step01 {
    public static void Run() {
        int count = Count(5);
        Console.WriteLine(count);
    }

    // Code 3-1
    static int Count(int num) {
        var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
        var count = 0;
        foreach (var n in numbers) {
            if (n == num) {
                count++;
            }
        }
        return count;
    }
}
