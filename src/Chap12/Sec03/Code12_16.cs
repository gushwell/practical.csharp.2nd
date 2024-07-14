using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Xml;
using System.Xml.Serialization;


public class Code12_16 {
    public static void Run() {
        using (var reader = XmlReader.Create("novel.xml")) {
            var serializer = new XmlSerializer(typeof(Novel));
            var novel = serializer.Deserialize(reader) as Novel;
            Console.WriteLine(novel);
        }
    }


}