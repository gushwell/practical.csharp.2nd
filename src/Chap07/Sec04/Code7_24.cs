public static class Code7_24 {
    public static void Run() {
        var books = Books.GetBooks();
        bool is1000OrLess = books.All(x => x.Price <= 1000);
        Console.WriteLine(is1000OrLess);
    }
}