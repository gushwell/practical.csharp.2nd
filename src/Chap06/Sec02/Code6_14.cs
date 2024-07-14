public static class Code6_14 {
    public static void Run() {
        var target = "141421356";
        var isAllDigits = target.All(c => Char.IsAsciiDigit(c));
        Console.WriteLine(isAllDigits);
    }

    public static void Bad() {
        string target = "141421356";
        bool isAllDigits = true;
        foreach (char c in target) {
            if (!Char.IsAsciiDigit(c)) {
                isAllDigits = false;
                break;
            }
        }
        Console.WriteLine(isAllDigits);
    }
}