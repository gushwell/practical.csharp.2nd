
public class Code5_17 {

    public static void Run() {
        var p1 = new Person() { FamilyName = "出井", GivenName = "あかり" };
        var p2 = new Person() { FamilyName = "出井", GivenName = "あかり" };
        if (p1 == p2) {
            Console.WriteLine("p1とp2は等しい");
        }
    }

    public record Person {
        public required string FamilyName { get; init; }
        public required string GivenName { get; init; }
    }

}

