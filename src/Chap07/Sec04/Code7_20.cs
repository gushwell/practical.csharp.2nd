public static class Code7_20 {
    public static void Run() {
        var numbers = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 11, 30, 24 };
        bool exists = numbers.Any(n => n % 7 == 0);
        Console.WriteLine(exists);
    }

    public static void Bad() {
        var numbers = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 11, 30, 24 };
        var count = numbers.Count(n => n % 7 == 0);
        // 条件に一致する要素数が 0 より大きければ存在している
        bool exists = count > 0;
        Console.WriteLine(exists);
    }
}