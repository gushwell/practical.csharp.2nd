
public class Code5_20 {

    public static void Run() {
        var student = new Student("井上はるか", new DateOnly(2007, 6, 14));
        student.Print();
    }

    public record Student(string Name, DateOnly Birthday) {
        public void Print() {
            Console.WriteLine($"{Name}さんは{Birthday.Year}年生まれです");
        }
    }


}

