public static class Code6_15 {
    public static void Run() {
        var target = "Novelist=谷崎潤一郎;BestWork=春琴抄"; ;
        var index = target.IndexOf("BestWork=");
        Console.WriteLine(index);
    }

    public static void Bad() {
        string target = "141421356";
        bool isAllDigits = true;
        foreach (char c in target) {
            if (!Char.IsDigit(c)) {
                isAllDigits = false;
                break;
            }
        }
        Console.WriteLine(isAllDigits);
    }
}