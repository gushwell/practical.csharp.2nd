public class Code5_18 {

    public static void Run() {
        var persons = new Person[] {
            new Person { FamilyName = "出井", GivenName = "あかり" },
            new Person { FamilyName = "出井", GivenName = "あかり" },
        };
        foreach (var p in persons.Distinct()) {
            Console.WriteLine(p);
        }
    }

    public record Person {
        public required string FamilyName { get; init; }
        public required string GivenName { get; init; }
    }

}

