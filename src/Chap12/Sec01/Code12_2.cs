using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

public class Code12_2 {
    public static void Run() {
        var novels = new Novel[] {
            new Novel {
                Author = "アイザック・アシモフ",
                Title = "われはロボット",
                PublishedYear = 1950,
            },
            new Novel {
                Author = "ジョージ・オーウェル",
                Title = "一九八四年",
                PublishedYear = 1949,
            },
        };

        var options = new JsonSerializerOptions {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };
        string jsonString = JsonSerializer.Serialize(novels, options);
        Console.WriteLine(jsonString);

    }


    public class Novel {
        public string Title { get; init; } = String.Empty;

        public string Author { get; init; } = String.Empty;

        public int PublishedYear { get; init; }
    }

}