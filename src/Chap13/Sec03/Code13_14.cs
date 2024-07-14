using System.Text.RegularExpressions;

public class Code13_14 {
    public static void Run() {
        var groups = Library.Categories
            .GroupJoin(Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, books) => new { Category = c.Name, Books = books });
        foreach (var group in groups) {
            Console.WriteLine(group.Category);
            foreach (var book in group.Books) {
                Console.WriteLine($"  {book.Title} ({book.PublishedYear}年)");
            }
        }
    }

}
