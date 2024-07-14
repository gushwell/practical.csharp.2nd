public static class Code16_9 {
    public static void Run() {
        // 16.10
        var evenNumbers = ProduceEvenNumbers(10);
        foreach (var n in evenNumbers) {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
    }

    // 16.9
    static IEnumerable<int> ProduceEvenNumbers(int upto) {
        for (int i = 0; i <= upto; i += 2) {
            yield return i;
        }
    }


}
