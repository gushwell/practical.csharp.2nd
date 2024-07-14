using System.Text;
using System.Xml;
using System.Xml.Serialization;


public class Code12_15 {
    public static void Run() {
        var novel = new Novel {
            Author = "ジェイムズ・P・ホーガン",
            Title = "星を継ぐもの",
            PublishedYear = 1977,
        };

        var stream = new MemoryStream();
        using (var writer = XmlWriter.Create(stream)) {
            var serializer = new XmlSerializer(novel.GetType());
            serializer.Serialize(writer, novel);
        }
    }



}