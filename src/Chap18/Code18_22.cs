namespace Code18_22;

class Bookshelf {
    private readonly List<Book> _books = new();

    public int Add(Book book) {
        _books.Add(book);
        return _books.Count;
    }
}

class Book { }