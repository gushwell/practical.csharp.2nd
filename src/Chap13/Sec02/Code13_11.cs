using System.Text.RegularExpressions;

public class Code13_11 {
    public static void Run() {
        var lookup = Library.Books
            .ToLookup(b => b.PublishedYear);
        var books = lookup[2022]; //- キーを指定して取り出したオブジェクトは、複数要素を保持するコレクション  
        foreach (var book in books) {
            Console.WriteLine(book);
        }
    }
}
