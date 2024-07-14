public static class Code7_43 {
    public static void Run() {
        List<int> numbers = new List<int> { 19, 17, 15, 24, 12, 17, 14, 20, 12, 28, 19, 30, 24 };
        List<int> results = new List<int>();
        foreach (int n in numbers) {
            if (!results.Contains(n)) {
                results.Add(n);
            }
        }
        foreach (int n in results) {
            Console.WriteLine(n);
        }
    }
}