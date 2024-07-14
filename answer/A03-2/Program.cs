var cities = new List<string> {
    "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
    "Canberra", "Hong Kong",
};

Exercise1(cities);
Console.WriteLine();
Exercise2(cities);
Console.WriteLine();
Exercise3(cities);
Console.WriteLine();
Exercise4(cities);


static void Exercise1(List<string> cities) {
    Console.WriteLine("都市名を入力。空行で終了");
    do {
        var name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
            break;
        var index = cities.FindIndex(s => s == name);
        Console.WriteLine(index);
    } while (true);
}

static void Exercise2(IEnumerable<string> cities) {
    var count = cities
        .Count(s => s.Contains('o'));
    Console.WriteLine(count);
}

static void Exercise3(IEnumerable<string> cities) {
    var selected = cities
        .Where(s => s.Contains('o'))
        .ToArray();
    foreach (var name in selected)
        Console.WriteLine(name);
}

static void Exercise4(IEnumerable<string> cities) {
    var selected = cities
        .Where(s => s.StartsWith("B"))
        .Select(s => s.Length);
    foreach (var length in selected)
        Console.WriteLine(length);
}
