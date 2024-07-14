public static class Code7_25 {
    public static void Run() {
        List<int> numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
        bool isAllPositive = true;
        foreach (int n in numbers) {
            if (n < 0) {
                isAllPositive = false;
                break;
            }
        }
        Console.WriteLine(isAllPositive);
    }

    static void NotRecommended() {
        List<int> numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
        bool isAllPositive = numbers.TrueForAll(delegate (int n) { return n > 0; });
    }
}