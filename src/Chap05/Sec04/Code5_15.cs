
public class Code5_15 {

    public static void Run() {
        var person = new Person {
            GivenName = "高山",
            FamilyName = "翔平",
        };

        // var person2 = new Person {
        //     GivenName = "高山"
        // };

    }
    public class Person {
        public required string GivenName { get; init; }

        public required string FamilyName { get; init; }
    }
}

