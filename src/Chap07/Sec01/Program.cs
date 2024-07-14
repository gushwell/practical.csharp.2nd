var books = Books.GetBooks();
foreach (var book in books) {
    Console.WriteLine($"{book.Title} {book.Pages}");
}
