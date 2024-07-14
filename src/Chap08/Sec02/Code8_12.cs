using Chap08;

public static class Code8_12 {
    public static void Run() {
        var employeeDict = new Dictionary<int, Employee> {
            [100] = new Employee(100, "井上はるか"),
            [112] = new Employee(112, "佐藤秀行"),
            [125] = new Employee(125, "鈴木絢香"),
        };
        var newDict = employeeDict
            .Where(x => x.Key > 110)
            .ToDictionary(e => e.Key, e => e.Value.Name);
        foreach (var (key, val) in newDict) {
            Console.WriteLine($"{key}={val}");
        }

    }

    // 書籍には未掲載
    public static void Other() {
        var flowerDict = new Dictionary<string, int>() {
            ["sunflower"] = 400,
            ["pansy"] = 300,
            ["tulip"] = 200,
            ["rose"] = 500,
            ["dahlia"] = 400,
        };
        var newDict = flowerDict
            .Where(x => x.Value >= 400)
            .ToDictionary(flower => flower.Key, flower => flower.Value);
        foreach (var (key, val) in newDict) {
            Console.WriteLine($"{key}={val}");
        }
    }
}
