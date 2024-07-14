using System.Text.RegularExpressions;

public class Code13_4 {
    public static void Run() {
        var average = Library.Books
            .Average(x => x.Price);
        var aboves = Library.Books
            .Where(b => b.Price > average);
        foreach (var book in aboves) {
            Console.WriteLine(book);
        }
    }
}
