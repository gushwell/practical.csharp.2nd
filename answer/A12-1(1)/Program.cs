using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;

var emp = new Employee {
    Id = 123,
    Name = "山田太郎",
    HireDate = new DateTime(2018, 10, 1),
};
var jsonString = Serialize(emp);
Console.WriteLine(jsonString);
var obj = Deserialize(jsonString);
Console.WriteLine(obj);

static string Serialize(Employee emp) {
    var options = new JsonSerializerOptions {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
        WriteIndented = true
    };
    string jsonString = JsonSerializer.Serialize(emp, options);
    return jsonString;
}

static Employee? Deserialize(string text) {
    var options = new JsonSerializerOptions {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
        WriteIndented = true
    };
    var emp = JsonSerializer.Deserialize<Employee>(text, options);
    return emp;
}


public record Employee {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime HireDate { get; set; }
}

