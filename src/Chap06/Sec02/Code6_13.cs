public static class Code6_13 {
    public static void Run() {
        var target = "C# Programming";
        var isExists = target.Any(c => Char.IsLower(c));
        Console.WriteLine(isExists);
    }

    public static void Bad() {
        var target = "C# Programming";
        bool isExists = false;
        foreach (char c in target) {
            if (Char.IsAsciiLetterLower(c)) {
                isExists = true;
                break;
            }
        }
        Console.WriteLine(isExists);
    }
}