public static class Code7_26 {
    public static void Run() {
        var numbers1 = new List<int> { 9, 7, 5, 4, 2, 4, 0, -4, -1, 0, 4 };
        var numbers2 = new List<int> { 9, 7, 5, 4, 2, 4, 0, -4, -1, 0, 4 };
        bool equal = numbers1.SequenceEqual(numbers2);
        Console.WriteLine(equal);
    }

}