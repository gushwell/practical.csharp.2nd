using System.Text.RegularExpressions;

public class Code13_6 {
    public static void Run() {
        var books = Library.Books
            .OrderByDescending(b => b.PublishedYear)
            .ThenBy(b => b.CategoryId)
            .ThenBy(b => b.Price); 
        foreach (var book in books) {
            Console.WriteLine(book);
        }
    }
}
