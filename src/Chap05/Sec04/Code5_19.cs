
public class Code5_19 {

    public static void Run() {
        var student = new Student("井上はるか", new DateOnly(2007, 6, 14));
        Console.WriteLine(student);
    }

    public record Student(string Name, DateOnly Birthday);

}

