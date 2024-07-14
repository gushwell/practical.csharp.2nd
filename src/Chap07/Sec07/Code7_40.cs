public static class Code7_40 {
    public static void Run() {
        var books = Books.GetBooks();
        var titles = books.Select(x => x.Title);
        titles.ToList().ForEach(Console.WriteLine);
    }
}