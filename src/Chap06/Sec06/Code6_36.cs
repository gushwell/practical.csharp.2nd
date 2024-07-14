public static class Code6_36 {
    public static void Run() {
        int number = 12345;
        var s1 = string.Format("{0,10}", number);       // "     12345"
        var s2 = string.Format("{0,10:#,0}", number);   // "    12,345"

        decimal distance = 9876.543m;
        var s3 = string.Format("{0,10}", distance);     // "  9876.543"
        var s4 = string.Format("{0,10:0.0}", distance); // "    9876.5"

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
    }
}