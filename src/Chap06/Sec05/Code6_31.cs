using System.Text;

public static class Code6_31 {
    public static void Run() {
        var sb = new StringBuilder();
        foreach (var word in GetWords()) {
            sb.Append(word);
        }
        var text = sb.ToString();
        Console.WriteLine(text);
    }

    private static string[] GetWords() {
        return ["Orange", "Lemon", "Strawberry"];
    }
}