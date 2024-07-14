public static class Code7_35 {
    public static void Run() {
        var books = Books.GetBooks();
        var selected = books.TakeWhile(x => x.Price < 600);
        foreach (var book in selected) {
            Console.WriteLine($"{book.Title} {book.Price}");
        }
    }
}