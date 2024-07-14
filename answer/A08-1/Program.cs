var text = "Cozy lummox gives smart squid who asks for job pen";

Exercise1(text);
Console.WriteLine();

Exercise2(text);

// 8.1.1
static void Exercise1(string text) {
    var dict = new Dictionary<Char, int>();
    foreach (var c in text) {
        var uc = char.ToUpper(c);
        if ('A' <= uc && uc <= 'Z') {
            if (dict.ContainsKey(uc))
                dict[uc]++;
            else
                dict[uc] = 1;
        }
    }
    foreach (var item in dict.OrderBy(x => x.Key)) {
        Console.WriteLine("{0}:{1}", item.Key, item.Value);
    }
}

// 8.1.2
static void Exercise2(string text) {
    var dict = new SortedDictionary<Char, int>();
    foreach (var c in text) {
        var uc = char.ToUpper(c);
        if ('A' <= uc && uc <= 'Z') {
            if (dict.ContainsKey(uc))
                dict[uc]++;
            else
                dict[uc] = 1;
        }
    }
    foreach (var item in dict) {
        Console.WriteLine("{0}:{1}", item.Key, item.Value);
    }
}