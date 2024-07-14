using System.Text.RegularExpressions;

public class Code13_12 {
    public static void Run() {
        var books = Library.Books
            .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new {
                    book.Title,
                    Category = category.Name,
                    book.PublishedYear
                }
            )
            .OrderBy(b => b.PublishedYear)
            .ThenBy(b => b.Category);
        foreach (var book in books) {
            Console.WriteLine($"{book.Title}, {book.Category}, {book.PublishedYear}");
        }
    }

}
