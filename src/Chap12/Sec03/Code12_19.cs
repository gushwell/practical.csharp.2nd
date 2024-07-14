using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


public class Code12_19 {
    public static void Run() {
        var novel = new Novel {
            Author = "ジェイムズ・P・ホーガン",
            Title = "星を継ぐもの",
            PublishedYear = 1977,
        };

        var sb = new StringBuilder();
        using (var writer = XmlWriter.Create(sb)) {
            var serializer = new XmlSerializer(novel.GetType());
            serializer.Serialize(writer, novel);
        }
        var xmlText = sb.ToString();
        Console.WriteLine(xmlText);
    }

    [XmlRoot("novel")]
    public record Novel {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; } = string.Empty;

        [XmlElement(ElementName = "author")]
        public string Author { get; set; } = string.Empty;

        [XmlElement(ElementName = "published")]
        public int PublishedYear { get; set; }

    }

}