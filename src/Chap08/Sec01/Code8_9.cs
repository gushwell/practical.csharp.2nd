using Chap08;

public static class Code8_9 {
    public static void Run() {
        var flowerDict = new Dictionary<string, int>() {
            ["sunflower"] = 400,
            ["pansy"] = 300,
            ["tulip"] = 350,
            ["rose"] = 500,
            ["dahlia"] = 450,
        };

        var employeeDict = new Dictionary<int, Employee> {
            [100] = new Employee(100, "井上はるか"),
            [112] = new Employee(112, "佐藤秀行"),
            [125] = new Employee(125, "鈴木絢香"),
        };

        // KeyValuePair<TKey, TValue>型で取り出す
        foreach (var item in flowerDict) {　//- itemは、KeyValuePair<string, int>型
            Console.WriteLine($"{item.Key} = {item.Value}");
        }

        // タプルで取り出す
        foreach (var (key, value) in flowerDict) {
            Console.WriteLine($"{key} = {value}");
        }

        Console.WriteLine();
    }
}
