public static class Code6_9 {
    public static void Run() {
        var str = "Visual Studio";

        if (str.StartsWith("Visual")) {
            Console.WriteLine("Visualで始まっています");
        }
    }

    public static void Bad() {
        var str = "Visual Studio";
        if (str.IndexOf("Visual") == 0) {
            Console.WriteLine("Visualで始まっています");
        }
    }
}