public static class Code6_2 {
    public static void Run() {
        var str1 = "Windows";
        var str2 = "WINDOWS";
        if (String.Compare(str1, str2, ignoreCase: true) == 0) {
            Console.WriteLine("等しい");
        } else {
            Console.WriteLine("等しくない");
        }
    }
}