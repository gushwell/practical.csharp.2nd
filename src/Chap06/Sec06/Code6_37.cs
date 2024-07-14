public static class Code6_37 {
    public static void Run() {
        var number = 12345;
        var s1 = $"{number:#,0}";      // "12,345"
        var s2 = $"{number:0000000}";  // "0012345"
        var s3 = $"{number,8}";        // "   12345"
        var s4 = $"{number,8:#,0}";    // "  12,345"

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
    }
}