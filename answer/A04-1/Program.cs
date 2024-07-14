List<string> langs = [
    "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
    "JavaScript", "Swift", "Go",
];

Exercise1(langs);
Console.WriteLine("---");
Exercise2(langs);
Console.WriteLine("---");
Exercise3(langs);

static void Exercise1(List<string> langs) {
    foreach (var lang in langs) {
        if (lang.Contains('S'))
            Console.WriteLine(lang);
    }
    Console.WriteLine("");

    for (var i = 0; i < langs.Count; i++) {
        var lang = langs[i];
        if (lang.Contains('S'))
            Console.WriteLine(lang);
    }
    Console.WriteLine("");

    var index = 0;
    while (index < langs.Count) {
        var lang = langs[index];
        if (lang.Contains('S'))
            Console.WriteLine(lang);
        index++;
    }
}

static void Exercise2(IEnumerable<string> langs) {
    var selected = langs.Where(x => x.Contains('S'));
    foreach (var lang in selected) {
        Console.WriteLine(lang);
    }
}

static void Exercise3(List<string> langs) {
    var lang = langs.Find(x => x.Length == 10);
    Console.WriteLine(lang ?? "Unknown");
}