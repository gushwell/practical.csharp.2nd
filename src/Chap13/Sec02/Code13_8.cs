using System.Text.RegularExpressions;

public class Code13_8 {
    public static void Run() {
        var groups = Library.Books
            .GroupBy(b => b.PublishedYear)
            .OrderByDescending(g => g.Key);
        foreach (var group in groups) {
            Console.WriteLine($"{group.Key}年");
            foreach (var book in group) {
                Console.WriteLine($"  {book}");
            }
        }
    }
}
