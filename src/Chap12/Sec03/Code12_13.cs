using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Xml;
using System.Xml.Serialization;


public class Code12_13 {
    public static void Run() {
        var novel = new Novel {
            Author = "ジェイムズ・P・ホーガン",
            Title = "星を継ぐもの",
            PublishedYear = 1977,
        };
        using (var writer = XmlWriter.Create("novel.xml")) {
            var serializer = new XmlSerializer(novel.GetType());
            serializer.Serialize(writer, novel);
        }
    }


}