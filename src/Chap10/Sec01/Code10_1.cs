using System.IO;
using System.Text;

public class Code10_1 {
    public static void Run() {
        var filePath = "./Greeting.txt";
        if (File.Exists(filePath)) {
            using var reader = new StreamReader(filePath, Encoding.UTF8);
            while (!reader.EndOfStream) {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }

    public static void Bad() {
        var filePath = "./Greeting.txt";
        if (File.Exists(filePath)) {
            using var reader = new StreamReader(filePath);
            string? line = null;
            while ((line = reader.ReadLine()) is not null) {
                Console.WriteLine(line);
            }
        }
    }

    public static void Bad2() {
        string filePath = "Greeting.txt";
        StreamReader reader = new StreamReader(filePath);
        try {
            while (!reader.EndOfStream) {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        } finally {
            reader.Dispose();  //- StreamReaderオブジェクトの後処理をする
        }

    }
}