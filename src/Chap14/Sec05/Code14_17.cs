
public class Code14_17 {

    public static void Run() {
        var books = new List<Book> {
            new Book { Title = "こころ", Price = 400, Pages = 378 },
            new Book { Title = "人間失格", Price = 281, Pages = 212 },
            new Book { Title = "伊豆の踊子", Price = 389, Pages = 201 },
            new Book { Title = "若草物語", Price = 637, Pages = 464 },
            new Book { Title = "銀河鉄道の夜", Price = 411, Pages = 276 },
            new Book { Title = "二都物語", Price = 961, Pages = 666 },
            new Book { Title = "遠野物語", Price = 514, Pages = 268 },
        };

        var selected = books
            .AsParallel()
            .WithDegreeOfParallelism(16)
            .Where(b => b.Price > 500 && b.Pages > 400)
            .Select(b => new { b.Title });
        foreach (var book in selected) {
            Console.WriteLine(book);
        }
    }

}