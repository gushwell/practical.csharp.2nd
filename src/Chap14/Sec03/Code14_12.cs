
public class Code14_12 {

    public static async Task Run() {
        await ExampleReadLinesAsync();
    }

    private static async Task ExampleReadLinesAsync() {
        string filePath = "羅生門.txt";
        await foreach (string line in File.ReadLinesAsync(filePath)) {
            Console.WriteLine(line);
        }
    }
}