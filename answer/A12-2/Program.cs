using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;

// C#11で追加された未加工の文字リテラルを利用

var jsonString = File.ReadAllText("./novelist.json");
var novelist = Deserialize(jsonString);
if (novelist is not null) {
    Console.WriteLine(novelist);
    foreach (var item in novelist.Masterpieces) {
        Console.WriteLine(item);
    }
}

static Novelist? Deserialize(string jsonString) {
    var options = new JsonSerializerOptions {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        NumberHandling =
            JsonNumberHandling.AllowNamedFloatingPointLiterals |
            JsonNumberHandling.AllowReadingFromString
    };
    var novelist = JsonSerializer.Deserialize<Novelist>(jsonString, options);
    return novelist;
}

public record Novelist {
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    [JsonPropertyName("birth")]
    public DateTime Birthday { get; init; }
    public string[] Masterpieces { get; init; } = [];
}

