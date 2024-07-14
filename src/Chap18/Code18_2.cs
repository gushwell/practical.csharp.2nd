
public class Code18_2 {
    static void SampleCode(Book book) {
        var strings = ReadLines();
        var authorsLine = GetAuthorsLine(strings);
        strings = authorsLine.Split(',', ';');
        book.Authors = new Authors(strings);
    }

    // 以下は単にビルドエラーにならないためのコード。
    static string[] ReadLines() {
        return [""];
    }

    static string GetAuthorsLine(string[] lines) {
        return "";
    }
}

public class Authors {
    public Authors(string[] strs) {

    }

}

public class Book {
    public Authors Authors { get; set; } = null!;
}