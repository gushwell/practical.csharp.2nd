using System.IO;
using System.Text;

public class Code10_11 {
    public static void Run() {
        var lines = new[] { "====", "京の夢", "大坂の夢", };
        var filePath = "./Example/いろは歌.txt";
        using (var writer = new StreamWriter(filePath, append: true)) {
            foreach (var line in lines)
                writer.WriteLine(line);
        }
        Utils.DisplayLines(filePath);
    }
}