using System.Text.RegularExpressions;

public class Code13_5 {
    public static void Run() {
        var query = Library.Books
            .Select(b => b.PublishedYear)
            .Distinct()
            .Order();
        foreach (var n in query)
            Console.WriteLine(n);

        // プロパティを指定してDistinctできる
        var query2 = Library.Books
            .DistinctBy(x => (x.PublishedYear, x.CategoryId))
            .Select(x => new { x.PublishedYear, x.CategoryId })
            .OrderBy(x => x.PublishedYear)
            .ThenBy(x => x.CategoryId);
        foreach (var n in query2)
            Console.WriteLine(n);

    }
}
