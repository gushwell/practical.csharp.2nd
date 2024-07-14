namespace Code18_23;
class MyBookList : List<Book> {
    private readonly List<Book> _deleted = new();
   　//…
    public new bool Remove(Book item) {
        _deleted.Add(item);
        return base.Remove(item);
    }
}

class Book {

}