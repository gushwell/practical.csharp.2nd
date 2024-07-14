public static class Code7_8 {
    public static void Run() {
        List<int> numbers = new List<int>();
        for (int i = 0; i < 20; i++) {
            numbers.Add(i + 1);
        }
        foreach (int num in numbers)
            Console.Write("{0} ", num);
        Console.WriteLine();
    }

}