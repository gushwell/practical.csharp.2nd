using System.Text.RegularExpressions;

public class Code13_2 {
    public static void Run() {
        var price = Library.Books
            .Where(b => b.CategoryId == 1)
            .Max(b => b.Price);
        Console.WriteLine(price);

    }
}
