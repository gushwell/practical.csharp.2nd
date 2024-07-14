using System.Runtime.CompilerServices;

public class Code16_2 {
    public static void Run() {
        var books = new MyBookList();
        books.Add(new Book("羅生門", "芥川龍之介"));
        books.Add(new Book("こころ", "夏目漱石"));
        books.Add(new Book("舞姫", "森鴎外"));
        Console.WriteLine(books[0]);
        Console.WriteLine(books[1]);
        Console.WriteLine(books[2]);
    }
}
