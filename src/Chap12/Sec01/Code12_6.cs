using System.Text.Json;


public class Code12_6 {
    public static void Run() {
        var text = File.ReadAllText("./novelists.json");
        var novelist = JsonSerializer.Deserialize<List<Novelist>>(text);
        novelist?.ForEach(Console.WriteLine);
    }
}