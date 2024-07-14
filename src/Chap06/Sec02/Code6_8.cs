public static class Code6_8 {
    public static void Run() {
        var str = "  　";
        if (String.IsNullOrWhiteSpace(str)) {
            Console.WriteLine("null あるいは 空文字列 あるいは 空白文字例です");
        }
    }
}