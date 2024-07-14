public static class Code7_17 {
    public static void Run() {
        var books = Books.GetBooks();
        var count = books.Count(x => x.Title.Contains("物語"));
        Console.WriteLine(count);
    }
}