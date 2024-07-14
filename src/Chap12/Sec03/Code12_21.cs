using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


public class Code12_21 {
    public static void Run() {
        var novels = new Novel[] {
            new Novel {
                Author = "ジェイムズ・P・ホーガン",
                Title = "星を継ぐもの",
                PublishedYear = 1977,
            },
            new Novel {
                Author = "H・G・ウェルズ",
                Title = "タイム・マシン",
                PublishedYear = 1895,
            },
        };

        using (var writer = XmlWriter.Create("novels.xml")) {
            XmlRootAttribute xRoot = new XmlRootAttribute {
                ElementName = "Novels"
            };
            var serializer = new XmlSerializer(novels.GetType(), xRoot);
            serializer.Serialize(writer, novels);
        }
    }

    public record Novel {
        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public int PublishedYear { get; set; }

    }

}