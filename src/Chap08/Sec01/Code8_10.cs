using Chap08;

public static class Code8_10 {
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

        var average = flowerDict.Average(x => x.Value);
        Console.WriteLine(average);

        int total = flowerDict.Sum(x => x.Value);
        Console.WriteLine(total);

        var items = flowerDict.Where(x => x.Key.Length <= 5);
        foreach (var item in items) {
            Console.WriteLine($"{item.Key} = {item.Value}");
        }
    }
}
