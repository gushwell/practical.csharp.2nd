
public class Code1_12 {
    public static void Run() {
        Employee employee = new Employee {
            Id = 100,
            Name = "山田太郎",
            Birthday = new DateTime(1992, 4, 5),
            DivisionName = "第一営業部",
        };
        Console.WriteLine($"{employee.Name}({employee.GetAge()})は、{employee.DivisionName}に所属しています。");
    }

}