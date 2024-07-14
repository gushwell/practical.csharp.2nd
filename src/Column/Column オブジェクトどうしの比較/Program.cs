// 値型の比較
{
    Console.WriteLine("値型の比較");
    int a = GetCurrentValue();
    int b = GetNextValue();
    if (a == b) {
        // a と b は等しい
        Console.WriteLine("aとbは等しい");
    }
}
// 値型の比較（構造体）
{
    Console.WriteLine("DateTime型の比較");
    DateTime d1 = GetMyBirthday();
    DateTime d2 = GetYourBirthday();
    if (d1 == d2) {
        // d1 と d2 は同じ日付
        Console.WriteLine("aとbは等しい");
    }
}

// 参照型の比較
{
    Console.WriteLine("Classの比較(1)");
    Sample a = new Sample { Num = 1, Str = "C#" };
    Sample b = new Sample { Num = 1, Str = "C#" };
    if (a == b) {
        // a と b は、メモリ上に別々に確保されたオブジェクトであるため、
        // ここに書かれたステートメントは実行されない
        Console.WriteLine("aとbは等しい");
    }
}

// 参照型の比較
{
    Console.WriteLine("Classの比較(2)");
    Sample a = new Sample { Num = 1, Str = "C#" };
    Sample b = a;
    if (a == b) {
        // a と b は、メモリ上の同じオブジェクトを参照しているため、
        // ここに書かれたステートメントが実行される
        Console.WriteLine("aとbは等しい");
    }
}

// 文字列の比較　（参照型）
{
    Console.WriteLine("stringの比較");
    var str1 = GetCurrentWord();  // "Hello"が返る
    var str2 = GetNextWord();     // 別の領域に確保された"Hello"が返る
    if (str1 == str2) {
        // 参照型の比較ではなく、値の比較が行われるので、別々の"Hello"であっても
        // ここに書かれたステートメントが実行される
        Console.WriteLine("aとbは等しい");
    }
}

// レコード型の比較　（参照型）
{
    Console.WriteLine("recordの比較");
    var a = new RecordSample { Num = 1, Str = "C#" };
    var b = new RecordSample { Num = 1, Str = "C#" };
    if (a == b) {
        // a と b は、各プロパティの値が同じであるため、等しいと判断される。
        // ここに書かれたステートメントは実行される。
        Console.WriteLine("aとbは等しい");
    }
}

static int GetCurrentValue() {
    return 10;
}

static int GetNextValue() {
    return 10;
}

static DateTime GetMyBirthday() {
    return new DateTime(2001, 8, 26);
}

static DateTime GetYourBirthday() {
    return new DateTime(2001, 8, 26);
}


static string GetCurrentWord() {
    return "Hello";
};

static string GetNextWord() {
    return "Hello";
};


public class Sample {
    public int Num { get; set; }
    public string Str { get; set; } = string.Empty;

}

public record RecordSample {
    public int Num { get; set; }
    public string Str { get; set; } = string.Empty;

}
