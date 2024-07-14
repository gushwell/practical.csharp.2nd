using System.Text.RegularExpressions;

public class Code13_13 {
    public static void Run() {
        var names = Library.Books
            .Where(b => b.PublishedYear == 2023)
            .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => category.Name)
            .Distinct();
        foreach (var name in names) {
            Console.WriteLine(name);
        }
    }

}
