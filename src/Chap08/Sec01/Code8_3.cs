using Chap08;

public static class Code8_3 {
    public static void Run() {
        var employeeDict = new Dictionary<int, Employee> {
            [100] = new Employee(100, "井上はるか"),
            [112] = new Employee(112, "佐藤秀行"),
            [125] = new Employee(125, "鈴木絢香"),
        };
        // 以下、確認のためのコード
        var emp0 = employeeDict[100];
        Console.WriteLine($"{emp0.Id} {emp0.Name}");
        var emp1 = employeeDict[112];
        Console.WriteLine($"{emp1.Id} {emp1.Name}");
        var emp2 = employeeDict[125];
        Console.WriteLine($"{emp2.Id} {emp2.Name}");
    }
}
