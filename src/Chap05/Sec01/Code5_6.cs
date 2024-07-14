
public static class Code5_6 {

    public static void Run() {
        var person = new Person {
            FamilyName = "佐藤",
            GivenName = "涼子"
        };
        Console.WriteLine(person.Name);

    }

    public class Person {
        public string GivenName { get; init; } = null!;

        public string FamilyName { get; init; } = null!;

        // getアクセサーのみを定義した読み取り専用プロパティ
        public string Name {
            get { return FamilyName + " " + GivenName; }
        }
    }
}
