using Chap08;

public static class Code8_11 {
    public static void Run() {
        var employees = new List<Employee>() {
                 new Employee(100, "井上はるか"),
                 new Employee(112, "佐藤秀行"),
                 new Employee(125, "鈴木絢香"),
            };

        var employeeDict = employees.ToDictionary(emp => emp.Id);

        Console.WriteLine(employeeDict[100].Name);
        Console.WriteLine(employeeDict[112].Name);
        Console.WriteLine(employeeDict[125].Name);

    }
}
