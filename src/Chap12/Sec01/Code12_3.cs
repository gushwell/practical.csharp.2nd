using System.Text.Json;
// using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;

public class Code12_3 {
    public static void Run() {
        var abbreviations = new Dictionary<string, string> {
            ["ODA"] = "政府開発援助",
            ["OECD"] = "経済協力開発機構",
            ["OPEC"] = "石油輸出国機構",
        };

        var options = new JsonSerializerOptions {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };
        string jsonString = JsonSerializer.Serialize(abbreviations, options); Console.WriteLine(jsonString);

        Console.WriteLine(jsonString);
    }

}