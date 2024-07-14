public static class Code7_21 {
    public static void Run() {
        var books = Books.GetBooks();
        bool exists = books.Any(x => x.Price >= 1000);
        Console.WriteLine(exists);
    }

    // 書籍には未掲載
    public static void Bad() {
        var books = Books.GetBooks();
        var count = books.Count(x => x.Price >= 1000);
        // 条件に一致する要素数が 0 より大きければ存在している
        bool exists = count > 0;
        Console.WriteLine(exists);
    }
}