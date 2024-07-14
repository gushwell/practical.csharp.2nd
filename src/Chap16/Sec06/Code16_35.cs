
public static class Code16_35 {
    public static void Run() {
        var p = new Person("佐藤秀行", 32);
        var (name, age) = p;
        Console.WriteLine($"{name} {age}");

        // 以下はビルドエラーになる
        // var p2 = new Person2 {
        //     Name = "佐藤秀行",
        //     Age = 32
        // };
        // var (name2, age2) = p2;  
        // Console.WriteLine($"{name2} {age2}");
    }

    record Person(string Name, int Age);

    record Person2 {
        public int Age { get; set; }

        public string Name { get; set; } = String.Empty;
    }
}
