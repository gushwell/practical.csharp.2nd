
public static class Code16_34 {
    public static void Run() {
        // 16.34
        var person = new Person {
            GivenName = "治",
            FamilyName = "太宰",
            Birthplace = "青森県"
        };

        var (name, birthplace) = person;
        Console.WriteLine($"{name}, {birthplace}");
    }


    // 16.33
    public class Person {
        public string GivenName { get; set; } = string.Empty;
        public string FamilyName { get; set; } = string.Empty;
        public string Birthplace { get; set; } = string.Empty;

        // タプルに分解するためのメソッド
        public void Deconstruct(out string name, out string birthplace) {
            name = FamilyName + GivenName;
            birthplace = Birthplace;
        }
    }
}