static class Step02 {
    public static void Run() {
        var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
        int count = Count(numbers, 5);
        Console.WriteLine(count);
    }
    
    // Code 3-2
    static int Count(int[] numbers, int num) {
        var count = 0;
        foreach (var n in numbers) {
            if (n == num) {
                count++;
            }
        }
        return count;
    }

}