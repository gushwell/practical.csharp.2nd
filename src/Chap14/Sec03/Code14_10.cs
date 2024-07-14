
public class Code14_10 {

    public static async Task Run() {
        var text = await ExampleReadAllTextAsync();
        Console.WriteLine(text);
    }

    private static async Task<string> ExampleReadAllTextAsync() {
        string filePath = "羅生門.txt";
        string text = await File.ReadAllTextAsync(filePath);
        return text;
    }
}