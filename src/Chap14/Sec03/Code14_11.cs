
public class Code14_11 {

    public static async Task Run() {
        await ExampleWriteAllTextAsync();
    }

    private static async Task ExampleWriteAllTextAsync() {
        string filePath = "sample.txt";
        string text = "Hello World";

        await File.WriteAllTextAsync(filePath, text);
    }
}