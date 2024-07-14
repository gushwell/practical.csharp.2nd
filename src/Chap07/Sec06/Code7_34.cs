public static class Code7_34 {
    public static void Run() {
        List<int> numbers = new List<int> { 9, 7, -5, -4, 2, 5, 4, 0, -4, 8, -1, 0, 4 };
        List<int> results = new List<int>();
        foreach (int n in numbers) {
            if (n > 0) {
                results.Add(n);
                if (results.Count >= 5)
                    break;
            }
        }
        foreach (int item in results) {
            Console.WriteLine(item);
        }
    }
}