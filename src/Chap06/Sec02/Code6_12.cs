public static class Code6_12 {
    public static void Run() {
        var target = "The quick brown fox jumps over the lazy dog.";
        var contains = target.Contains('b');
        Console.WriteLine(contains);
    }

    static void Bad() {
        var target = "The quick brown fox jumps over the lazy dog.";
        // 文字列の中に指定した文字があるかを調べる悪い例
        var contains = target.IndexOf('b') >= 0;
        Console.WriteLine(contains);
    }
}