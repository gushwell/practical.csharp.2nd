public class MyBookList {
    private readonly List<Book> _list = new();

    public bool Add(Book book) {
        if (_list.Contains(book))
            return false;
        _list.Add(book);
        return true;
    }

    // インデクサーの定義
    public Book this[int index] {
        get {
            return _list[index];
        }
    }
}

public record Book(string Name, string Author);
