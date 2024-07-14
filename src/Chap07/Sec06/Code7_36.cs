public static class Code7_36 {
    public static void Run() {
        var books = Books.GetBooks();
        List<Book> selected = new List<Book>();
        foreach (Book book in books) {
            if (book.Price >= 600)
                break;
            selected.Add(book);
        }
        foreach (Book book in selected) {
            Console.WriteLine($"{book.Title} {book.Price}");
        }
    }
}