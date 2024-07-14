using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;


public class Code12_10 {
    public static void Run() {
        var options = new JsonSerializerOptions {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        var text = File.ReadAllText("./novels.json");
        var novelist = JsonSerializer.Deserialize<List<Novel>>(text, options);
        novelist?.ForEach(Console.WriteLine);
    }

    public record Novel {
        public string Title { get; init; } = String.Empty;

        public string Author { get; init; } = String.Empty;

        [JsonPropertyName("year")]
        public int PublishedYear { get; init; }
    }


}