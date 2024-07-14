using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


public class Code12_22 {
    public static void Run() {
        using (var reader = XmlReader.Create("novels.xml")) {
            var serializer = new XmlSerializer(typeof(Novels));
            if (serializer.Deserialize(reader) is Novels novels) {
                foreach (var novel in novels.NovelList) {
                    Console.WriteLine(novel);
                }
            }
        }
    }

    [XmlRoot("Novels")]
    public class Novels {
        [XmlElement("Novel")]
        public List<Novel> NovelList { get; set; } = new();
    }

    public record Novel {
        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public int PublishedYear { get; set; }

    }

}