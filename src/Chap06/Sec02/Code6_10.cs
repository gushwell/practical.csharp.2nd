public static class Code6_10 {
    public static void Run() {
        var str = "InvalidException";
        if (str.EndsWith("Exception")) {
            Console.WriteLine("Exceptionで終わっています");
        }
    }

}