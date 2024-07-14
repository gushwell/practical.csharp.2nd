using System.Text.RegularExpressions;

public class Code13_7 {
    public static void Run() {
        var years = new int[] { 2020, 2023 };
        var books = Library.Books
            .Where(b => years.Contains(b.PublishedYear));
        foreach (var book in books) {
            Console.WriteLine(book);
        }
    }
}
