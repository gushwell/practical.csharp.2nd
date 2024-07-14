public static class Code7_45 {
    public static void Run() {
        var books = Books.GetBooks();
        var sortedBooks = books
            .OrderByDescending(x => x.Price)
            .ThenByDescending(x => x.Pages);
        foreach (var book in sortedBooks) {
            Console.WriteLine($"{book.Title} {book.Price}");
        }
    }

    public static void Bad() {
        var books = Books.GetBooks();
        books.OrderBy(x => x.Price); //- 結果を受け取っていない！
        foreach (var book in books) {
            Console.WriteLine($"{book.Title} {book.Price}");
        }
    }
}