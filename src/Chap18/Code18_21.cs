namespace Code18_21;

class Bookshelf {
    private List<Book> _books = new();

    public Book Book { get; set; }

    public int Add() {
        _books.Add(Book);
        return _books.Count;
    }
}

// 以下は単にビルドエラーにならないためのコード。

class Book { }