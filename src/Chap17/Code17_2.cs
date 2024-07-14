using System.Text;

public class Code17_2 {
    public static void Run() {
        var filePath = "";
        if (string.IsNullOrEmpty(filePath))
            filePath = GetDefaultFilePath();
        if (File.Exists(filePath)) {
            using (var reader = new StreamReader(filePath, Encoding.UTF8)) {
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
    }

    private static string GetDefaultFilePath() {
        return "";
    }
}
