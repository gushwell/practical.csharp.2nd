public class Code16_42 {
    public static void Run() {

        var user = new User(Gender.Female, 65);
        var discount = user switch {
            (_, <= 12) => 50,
            (_, >= 60) => 10,
            (Gender.Female, _) when DateTime.Today.Day == 15 => 5,
            _ => 0,
        };
        Console.WriteLine($"割引率:{discount}%");
    }

    public record User(Gender gender, int age);

    public enum Gender {
        Male,
        Female,
    }
}