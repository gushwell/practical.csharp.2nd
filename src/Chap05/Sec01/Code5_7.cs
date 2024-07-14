
public static class Code5_7 {

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

        public string Name => FamilyName + " " + GivenName;
    }

}
