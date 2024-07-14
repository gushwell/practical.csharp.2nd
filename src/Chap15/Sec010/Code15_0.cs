public class Code15_0 {
    public static void Run() {
        List<object> list = [
            new GreetingMorning(),
            new GreetingAfternoon(),
            new GreetingEvening(),
        ];
        foreach (object obj in list) {
            string msg = obj.GetMessage();　//- この行でビルドエラー
            Console.WriteLine(msg);
        }

    }
}

class GreetingMorning {
    public string GetMessage() => "おはよう";
}

class GreetingAfternoon {
    public string GetMessage() => "こんにちは";
}

class GreetingEvening {
    public string GetMessage() => "こんばんは";
}
