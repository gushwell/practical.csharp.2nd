public static class Code6_11 {
    public static void Run() {
        var str = "C# Program";
        if (str.Contains("Program")) {
            Console.WriteLine("Programが含まれています");
        }
    }

    public static void Bad() {
        var str = "C# Program";
        if (str.IndexOf("Program") >= 0) {
            Console.WriteLine("Programが含まれています");
        }
    }
}