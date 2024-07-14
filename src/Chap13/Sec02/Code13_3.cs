using System.Text.RegularExpressions;

public class Code13_3 {
    public static void Run() {
        var book = Library.Books
            .Where(x => x.PublishedYear >= 2021)
            .MinBy(x => x.Price);
        Console.WriteLine(book);

        var book2 = Library.Books
            .Where(x => x.PublishedYear >= 2021)
            .First(b => b.Price == Library.Books.Min(x => x.Price));
        Console.WriteLine(book2);

    }
}
