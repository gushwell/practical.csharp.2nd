using CSharp.Exercise;

// 5.2.1
var ymCollection = new YearMonth[] {
    new YearMonth(1980, 1),
    new YearMonth(1990, 4),
    new YearMonth(2000, 7),
    new YearMonth(2010, 9),
    new YearMonth(2024, 12),
};

Console.WriteLine("5.2.2");
Exercise2(ymCollection);

Console.WriteLine("5.2.4");
Exercise4(ymCollection);


Console.WriteLine("5.2.5");
Exercise5(ymCollection);

// 5.2.2
static void Exercise2(YearMonth[] ymCollection) {
    foreach (var ym in ymCollection) {
        Console.WriteLine(ym);
    }
}

// 5.2.3
static YearMonth? FindFirst21C(YearMonth[] yms) {
    foreach (var ym in yms) {
        if (ym.Is21Century)
            return ym;
    }
    return null;
}

// 5.2.4
static void Exercise4(YearMonth[] ymCollection) {
    var yearmonth = FindFirst21C(ymCollection);
    if (yearmonth is null)
        Console.WriteLine("21世紀のデータはありません");
    else
        Console.WriteLine(yearmonth);


    // あるいは、以下のような書き方もできる
    Console.WriteLine("----");
    var yearmonth2 = FindFirst21C(ymCollection);
    var s = yearmonth2?.ToString() ?? "21世紀のデータはありません";
    Console.WriteLine(s);
}

// 5.2.5
static void Exercise5(YearMonth[] ymCollection) {
    var array = ymCollection
        .Select(ym => ym.AddOneMonth())
        .ToArray();
    foreach (var ym in array) {
        Console.WriteLine(ym);
    }
}