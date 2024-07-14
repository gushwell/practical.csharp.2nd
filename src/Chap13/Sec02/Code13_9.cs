using System.Text.RegularExpressions;

public class Code13_9 {
    public static void Run() {
        var selected = Library.Books
            .GroupBy(b => b.PublishedYear)
            .Select(group => group.MaxBy(b => b.Price))
            .OrderBy(b => b!.PublishedYear);
        foreach (var book in selected) {
            Console.WriteLine($"{book!.PublishedYear}年 {book!.Title} ({book!.Price})");
        }
    }
    public static void Run2() {
        var selected = Library.Books
            .GroupBy(b => b.PublishedYear)
            .Select(group => group.OrderByDescending(b => b.Price)
                                  .First())
            .OrderBy(b => b.PublishedYear);
        foreach (var book in selected) {
            Console.WriteLine($"{book.PublishedYear}年 {book.Title} ({book.Price})");
        }
    }
}
