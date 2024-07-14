using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;


public class Code12_11 {
    public static void Run() {
        var text = """
        [
            {
                "date": "2024-01-02T00:00:00",
                "temperature": "NaN",
                "maxBloodPressure": "128",
                "minBloodPressure": "64"
            },
            {
                "date": "2024-01-03T00:00:00",
                "temperature": "36.4",
                "maxBloodPressure": "131",
                "minBloodPressure": "69"
            }
        ]
        """;

        var options = new JsonSerializerOptions {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            NumberHandling =
                JsonNumberHandling.AllowNamedFloatingPointLiterals |
                JsonNumberHandling.AllowReadingFromString,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };
        var healths = JsonSerializer.Deserialize<List<HealthRecord>>(text, options);
        healths?.ForEach(Console.WriteLine);
    }

    public record HealthRecord {
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
        public int MaxBloodPressure { get; set; }
        public int MinBloodPressure { get; set; }
    }


}