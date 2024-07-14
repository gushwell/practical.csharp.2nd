using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;
using System.Text.Unicode;


public class Code12_8 {
    public static void Run() {
        var persons = new Person[] {
            new Person {
            FamilyName = "佐藤",
            GivenName = "涼子"
        },
        new Person {
            GivenName = "高山",
            FamilyName = "翔平",
        },
        };

        var options = new JsonSerializerOptions {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            IgnoreReadOnlyProperties = true,
            WriteIndented = true
        };
        string jsonString = JsonSerializer.Serialize(persons, options);
        Console.WriteLine(jsonString);
    }

    public class Person {
        public string GivenName { get; init; } = null!;

        public string FamilyName { get; init; } = null!;

        public string Name => FamilyName + " " + GivenName;
    }



}