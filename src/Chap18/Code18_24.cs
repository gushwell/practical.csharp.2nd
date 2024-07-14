using System.Collections;

namespace Code18_24;

class MyBookList : ICollection<Book> {
    private readonly List<Book> _books = new();
    private readonly List<Book> _deleted = new();

    public int Count =>
        ((ICollection<Book>)_books).Count;

    public bool IsReadOnly => ((ICollection<Book>)_books).IsReadOnly;

    public void Add(Book item) {
        ((ICollection<Book>)_books).Add(item);
    }

    public void Clear() {
        ((ICollection<Book>)_books).Clear();
    }

    public bool Contains(Book item) {
        return ((ICollection<Book>)_books).Contains(item);
    }

    public void CopyTo(Book[] array, int arrayIndex) {
        ((ICollection<Book>)_books).CopyTo(array, arrayIndex);
    }

    public IEnumerator<Book> GetEnumerator() {
        return ((IEnumerable<Book>)_books).GetEnumerator();
    }

    public bool Remove(Book item) {
        _deleted.Add(item);
        return ((ICollection<Book>)_books).Remove(item);
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return ((IEnumerable)_books).GetEnumerator();
    }
    //  …
}

// 以下は単にビルドエラーにならないためのコード。

class Book { }