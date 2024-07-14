using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;

var filePath = "./employees.json";
Exercise2(filePath);
Exercise3(filePath);

static void Exercise2(string filePath) {
    Employee[] employees = [
        new () {
            Id = 123,
            Name = "山田太郎",
            HireDate = new DateTime(2018, 10, 1),
        },
        new () {
            Id = 198,
            Name = "田中華子",
            HireDate = new DateTime(2020, 4, 1),
        },
    ];
    Serialize(filePath, employees);
}

static void Serialize(string filePath, IEnumerable<Employee> employees) {
    var options = new JsonSerializerOptions {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
        WriteIndented = true
    };
    byte[] utf8Bytes = JsonSerializer.SerializeToUtf8Bytes(employees, options);
    File.WriteAllBytes(filePath, utf8Bytes);

}


static void Exercise3(string filePath) {
    var employees = Deserialize(filePath);
    foreach (var emp in employees)
        Console.WriteLine(emp);
}

static Employee[] Deserialize(string filePath) {
    var options = new JsonSerializerOptions {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
        WriteIndented = true
    };
    var text = File.ReadAllText(filePath);
    var employees = JsonSerializer.Deserialize<Employee[]>(text, options);
    return employees ?? [];
}


public record Employee {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime HireDate { get; set; }
}

