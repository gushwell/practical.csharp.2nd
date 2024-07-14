public static class Code7_14 {
    public static void Run() {
        var books = Books.GetBooks();
        var maxMages = books.Max(x => x.Pages);
        Console.WriteLine(maxMages);
    }
}