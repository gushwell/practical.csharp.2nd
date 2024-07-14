using Chap08;

public static class Code8_6 {
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

        int price = flowerDict["rose"];

        var employee = employeeDict[125];

        Console.WriteLine($"price={price}");
        Console.WriteLine($"employee={employee.Id} {employee.Name}");
    }
}
