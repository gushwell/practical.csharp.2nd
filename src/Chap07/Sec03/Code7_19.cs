public static class Code7_19 {
    public static void Run() {
        var books = Books.GetBooks();
        int count = 0;
        foreach (Book book in books) {
            if (book.Title.Contains("物語")) {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}