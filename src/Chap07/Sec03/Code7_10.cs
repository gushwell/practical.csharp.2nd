public static class Code7_10 {
    public static void Run() {
        var books = Books.GetBooks();

        var average = books.Average(x => x.Price);
        Console.WriteLine(average);
    }
}