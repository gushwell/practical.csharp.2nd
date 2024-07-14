
ExistsSample();
FindSample();
FindIndexSample();
FindAllSample();
RemoveAllSample();
ForEachSample();
ConvertAllSample();


static void ExistsSample() {
    var cities = new List<string> {
        "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
        "Canberra", "Hong Kong",
    };
    var exists = cities.Exists(s => s[0] == 'A');
    Console.WriteLine(exists);
    Console.WriteLine();
}

static void FindSample() {
    var cities = new List<string> {
        "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
        "Canberra", "Hong Kong",
    };
    var name = cities.Find(s => s.Length == 6);
    Console.WriteLine(name);
    Console.WriteLine();
}

static void FindIndexSample() {
    var cities = new List<string> {
        "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
        "Canberra", "Hong Kong",
    };
    int index = cities.FindIndex(s => s == "Berlin");
    Console.WriteLine(index);
    Console.WriteLine();
}

static void FindAllSample() {
    var cities = new List<string> {
        "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
        "Canberra", "Hong Kong",
    };
    var names = cities.FindAll(s => s.Length <= 5);
    foreach (var s in names) {
        Console.WriteLine(s);
    }
    Console.WriteLine();
}
static void RemoveAllSample() {
    var cities = new List<string> {
        "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
        "Canberra", "Hong Kong",
    };
    var removedCount = cities.RemoveAll(s => s.Contains("on"));
    Console.WriteLine(removedCount);
    Console.WriteLine();
}

static void ForEachSample() {
    var cities = new List<string> {
        "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
        "Canberra", "Hong Kong",
    };
    cities.ForEach(s => Console.WriteLine(s));
    foreach (var s in cities) {
        Console.WriteLine(s);
    }
    Console.WriteLine();
}

static void ConvertAllSample() {
    var cities = new List<string> {
        "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
        "Canberra", "Hong Kong",
    };
    var lowerList = cities.ConvertAll(s => s.ToLower());
    lowerList.ForEach(s => Console.WriteLine(s));
}
