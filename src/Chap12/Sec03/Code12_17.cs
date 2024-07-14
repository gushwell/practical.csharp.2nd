using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Xml;
using System.Xml.Serialization;


public class Code12_17 {
    public static void Run() {
        var xmlText = """
        <?xml version="1.0" encoding="utf-8"?>
        <Novel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" 
          xmlns:xsd="http://www.w3.org/2001/XMLSchema">
          <Title>星を継ぐもの</Title>
          <Author>ジェイムズ・P・ホーガン</Author>
          <PublishedYear>1977</PublishedYear>
        </Novel>
        """;

        using (var reader = XmlReader.Create(new StringReader(xmlText))) {
            var serializer = new XmlSerializer(typeof(Novel));
            var novel = serializer.Deserialize(reader) as Novel;
            Console.WriteLine(novel);
        }
    }

    public record HealthRecord {
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
        public int MaxBloodPressure { get; set; }
        public int MinBloodPressure { get; set; }
    }


}