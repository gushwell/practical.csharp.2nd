public static class Code7_46 {
    public static void Run() {
        var books = Books.GetBooks();
        books.Sort(BookCompare);  //- List<Book>をソート
        foreach (var book in books) {
            Console.WriteLine($"{book.Title} {book.Price}");
        }
    }

    private static int BookCompare(Book a, Book b) => a.Price - b.Price;

}

public static class List7_46_2 {
    public static void Run() {
        var books = Books.GetBooks();
        books.Sort(BookCompare);  //- List<Book>をソート
        foreach (var book in books) {
            Console.WriteLine($"{book.Title} {book.Price}");
        }
    }

    private static int BookCompare(Book a, Book b) => b.Price - a.Price;

}
