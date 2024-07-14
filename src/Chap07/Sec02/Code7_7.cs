public static class Code7_7 {
    public static void Run() {
        int[] numbers = new int[20];
        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = i + 1;
        }
        foreach (int num in numbers)
            Console.Write($"{num} ");
        Console.WriteLine();
    }

}