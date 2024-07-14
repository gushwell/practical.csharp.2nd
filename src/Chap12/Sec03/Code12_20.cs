using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


public class Code12_20 {
    public static void Run() {
        var novelist = new Novelist {
            Name = "アーサー・C・クラーク",
            Masterpieces = new string[] {
            "2001年宇宙の旅",
            "幼年期の終り",
        }
        };
        using (var writer = XmlWriter.Create("novelist.xml")) {
            var serializer = new XmlSerializer(novelist.GetType());
            serializer.Serialize(writer, novelist);
        }
    }

    [XmlRoot("novelist")]
    public class Novelist {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; } = string.Empty;

        [XmlArray("masterpieces")]
        [XmlArrayItem("title", typeof(string))]
        public string[] Masterpieces { get; set; } = new string[0];
    }

}