Code3_7.SimpleQuery();
SimpleQuery2();
SimpleQuery3();
SimpleQuery4();
Code3_8.DeferredSample();
Code3_9.ImmediateQuery();
ImmediateQuery2();

// 以下、リスト番号が振られていないコード

static void SimpleQuery2() {
    var cities = new List<string> {
        "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
    };
    var query = cities.Where(s => s.Length <= 5)
                     .Select(s => s.ToLower());
    foreach (string s in query) {
        Console.WriteLine(s);
    }
}

static void SimpleQuery3() {
    var cities = new List<string> {
        "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
    };
    var query = cities.Select(s => s.Length);
    foreach (var n in query) {
        Console.Write($"{n} ");
    }
    Console.WriteLine();
}

// これは書籍には無い。
static void SimpleQuery4() {
    var cities = new List<string> {
        "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
    };
    var exists = cities.Any(s => s == "London");
    Console.WriteLine(exists);
}


static void ImmediateQuery2() {
    string[] cities = {
        "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra",
    };
    var count = cities.Count(s => s.Length > 5);
    Console.WriteLine(count);
}
