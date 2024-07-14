public class Code5_11 {

    public static void Run() {
        DoSomething(100);

        DoSomething(100, "エラーです");

        DoSomething(100, "エラーです", 5);

    }

    public static void DoSomething(int num, string message = "失敗しました", int retryCount = 3) {
        // 仮のコード。
        Console.WriteLine($"{num} {message} {retryCount}");
    }
}